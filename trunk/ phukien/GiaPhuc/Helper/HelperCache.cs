using System;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;
using System.Collections;
using System.Reflection;

namespace MichaelKappel.Net.CSharp 
{
    public class HelperCache
    {
        private static System.Web.Caching.Cache cache = HttpContext.Current.Cache;
        private static partial class Config
        {
            /// <summary>
            /// Configuration Setting indicates if system has Caching Enabled.
            /// </summary>
            public static Boolean CacheEnabled
            {
                get
                {
                    Boolean reuslt = true;
                    return (!Boolean.TryParse(ConfigurationManager.AppSettings["CacheEnabled"], out reuslt) || reuslt);
                }
            }
            /// <summary>
            /// Configuration Setting indicates the time of day all Cache is Cleared out completely.
            /// Default never completely clears cache, this setting must be added to clear out cache completely at a specific time every day.
            /// </summary>
            public static String CacheClearingTime
            {
                get
                {
                    return ConfigurationManager.AppSettings["CacheClearingTime"];
                }
            }
            /// <summary>
            ///  Amount of time in hours "Long Term" cache is kept since the last time it was accessed
            ///  This should be used for data that does not change very often and frequently accessed.
            ///  Default is 2 hours
            /// </summary>
            public static Int32 CacheLongTerm
            {
                get
                {
                    Int32 result = 0;
                    return (Int32.TryParse(ConfigurationManager.AppSettings["CacheLongTerm"], out result)) ? result : 2;
                }
            }
            /// <summary>
            ///  Amount of time in minutes "Short Term" cache is kept since the last time it was accessed
            ///  This should be used to avoid repeated calls to the database for very recentrequests, reordering, paging, and filtering
            ///  Default is 5 minutes
            /// </summary>
            public static Int32 CacheShortTerm
            {
                get
                {
                    Int32 result = 0;
                    return (Int32.TryParse(ConfigurationManager.AppSettings["CacheShortTerm"], out result)) ? result : 5;
                }
            }
        }
        /// <summary>
        ///  Indicates whether caching is enabled.
        /// </summary>
        public static Boolean IsEnabled
        {
            get
            {
                return Config.CacheEnabled;
            }
        }
        /// <summary>
        ///  Indicates whether caching is enabled.
        /// </summary>
        public static Boolean IsClearingEnabled
        {
            get
            {
                return (!String.IsNullOrEmpty(Config.CacheClearingTime));
            }
        }
        /// <summary>
        ///  Date and time the next cache clear was performed.
        /// </summary>
        public static Nullable<DateTime> NextClearingTime
        {
            get
            {
                if (!IsEnabled || !IsClearingEnabled) return null;
                Boolean WillClearToday = LastCleared.HasValue
                    && LastCleared.Value.Date == DateTime.Now.Date
                    && DateTime.Compare(DateTime.Now, Convert.ToDateTime(DateTime.Now.Date.ToShortDateString() + " " + Config.CacheClearingTime)) < 0;
                return (WillClearToday) ?
                    DateTime.Parse(DateTime.Now.Date.ToShortDateString() + " " + Config.CacheClearingTime) :
                    DateTime.Parse(DateTime.Now.AddDays(1).Date.ToShortDateString() + " " + Config.CacheClearingTime);
            }
        }
        /// <summary>
        ///  Date and time the last cache clear was performed.
        /// </summary>
        public static Nullable<DateTime> LastCleared
        {
            get
            {
                if (!IsEnabled || !IsClearingEnabled) return null;
                if (HttpContext.Current.Cache["CacheLastCleared"] == null) Clear();
                return (DateTime)HttpContext.Current.Cache["CacheLastCleared"];
            }
        }
        /// <summary>
        ///  If cache is due to be clear cleared this will clear it.
        /// </summary>
        public static void Check()
        {
            if (NextClearingTime.HasValue && NextClearingTime.Value < DateTime.Now) Clear();
        }
        /// <summary>
        /// Clears all items from cache
        /// </summary>
        public static void Clear()
        {
            if (IsEnabled)
            {
                IDictionaryEnumerator CacheEnum = HttpContext.Current.Cache.GetEnumerator();
                while (CacheEnum.MoveNext()) HttpContext.Current.Cache.Remove(CacheEnum.Key.ToString());
                HttpContext.Current.Cache["CacheLastCleared"] = DateTime.Now;
            }
        }
        public enum CachingTime
        {
            LongTermAbsolute,
            LongTermSliding,
            ShortTermSliding
        }
        /// <summary>
        /// Will add Object to Cache if:
        /// 1. Debug mode is "ON" and "DebugCacheDisabled" session is not "True"
        /// 2. If caching is enabled
        /// 3. The Object is not Null
        /// 4. The Object is not already in Cache
        /// 5. The Object is Cacheable
        /// </summary>
        /// <typeparam name="T">Type of Object</typeparam>
        /// <param name="key">Key to retrieve Object</param>
        /// <param name="obj">Object to store in Cache</param>
        /// <param name="cacheDependencies">List of Cache Keys item is dependent on</param>
        /// <returns></returns>
        public static CacheAddResult Add(String key, Object obj, String[] cacheDependencies)
        {
            return Add(key, obj, CachingTime.LongTermSliding, cacheDependencies);
        }
        /// <summary>
        /// Will add Object to Cache if:
        /// 1. Debug mode is "ON" and "DebugCacheDisabled" session is not "True"
        /// 2. If caching is enabled
        /// 3. The Object is not Null
        /// 4. The Object is not already in Cache
        /// 5. The Object is Cacheable
        /// </summary>
        /// <typeparam name="T">Type of Object</typeparam>
        /// <param name="key">Key to retrieve Object</param>
        /// <param name="obj">Object to store in Cache</param>
        /// <returns></returns>
        public static CacheAddResult Add(String key, Object obj)
        {
            return Add(key, obj, CachingTime.LongTermSliding);
        }
        /// <summary>
        /// Will add Object to Cache if:
        /// 1. Debug mode is "ON" and "DebugCacheDisabled" session is not "True"
        /// 2. If caching is enabled
        /// 3. The Object is not Null
        /// 4. The Object is not already in Cache
        /// 5. The Object is Cacheable
        /// </summary>
        /// <typeparam name="T">Type of Object</typeparam>
        /// <param name="key">Key to retrieve Object</param>
        /// <param name="obj">Object to store in Cache</param>
        /// <returns></returns>
        public static CacheAddResult Add(String key, Object obj, CachingTime SpecialCacheSetting)
        {
            return Add(key, obj, SpecialCacheSetting, null);
        }
        /// <summary>
        /// Will add Object to Cache if:
        /// 1. Debug mode is "ON" and "DebugCacheDisabled" session is not "True"
        /// 2. If caching is enabled
        /// 3. The Object is not Null
        /// 4. The Object is not already in Cache
        /// 5. The Object is Cacheable
        /// </summary>
        /// <typeparam name="T">Type of Object</typeparam>
        /// <param name="key">Key to retrieve Object</param>
        /// <param name="obj">Object to store in Cache</param>
        /// <param name="cacheDependencies">List of Cache Keys item is dependent on</param>
        /// <returns></returns>
        public static CacheAddResult Add(String key, Object obj, CachingTime SpecialCacheSetting, String[] cacheDependencies)
        {
            if (HttpContext.Current.IsDebuggingEnabled && HttpContext.Current.Session != null && MichaelKappel.Net.CSharp.Helper.ParseTo<Boolean>(HttpContext.Current.Session["DebugCacheDisabled"]))
                return CacheAddResult.DebugDisabled;

            Check();
            TimeSpan CacheTimeSpan;
            if (
                   (
                        (!Config.CacheEnabled || Config.CacheLongTerm == 0)
                   &&
                        (SpecialCacheSetting == CachingTime.LongTermAbsolute || SpecialCacheSetting == CachingTime.LongTermSliding)
                   )
                   || (SpecialCacheSetting == CachingTime.ShortTermSliding && Config.CacheShortTerm == 0)
                )
            {
                return CacheAddResult.Disabled;
            }
            else if (obj == null)
            {
                return CacheAddResult.Null;
            }
            else if (HttpContext.Current.Cache[key] != null)
            {
                return CacheAddResult.Conflict;
            }
            else if (SpecialCacheSetting == CachingTime.ShortTermSliding)
            {
                CacheTimeSpan = TimeSpan.FromMinutes(Config.CacheShortTerm);
            }
            else
            {
                CacheTimeSpan = TimeSpan.FromHours(Config.CacheLongTerm);
            }

            if (SpecialCacheSetting == CachingTime.LongTermAbsolute)
            {
                cache.Add(key, obj, new CacheDependency(null, cacheDependencies), DateTime.Now.Add(CacheTimeSpan), System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.High, null);
            }
            else
            {
                cache.Add(key, obj, new CacheDependency(null, cacheDependencies), System.Web.Caching.Cache.NoAbsoluteExpiration, CacheTimeSpan, CacheItemPriority.High, null);
            }
            return CacheAddResult.OK;
        }

        /// <summary>
        /// Site cache method outcomes
        /// </summary>
        public enum CacheAddResult
        {
            /// <summary>
            /// Added to Cache
            /// </summary>
            OK,
            /// <summary>
            /// If caching is Disabled
            /// </summary>
            Disabled,
            /// <summary>
            /// Debug is Disabled
            /// </summary>
            DebugDisabled,
            /// <summary>
            /// The Object to be added is Null
            /// </summary>
            Null,
            /// <summary>
            /// The key is not already in Cache
            /// </summary>
            Conflict,
            /// <summary>
            /// Object not allowed
            /// </summary>
            Forbidden
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T Get<T>(String key)
        {
            if (cache[key] != null)
            {
                T result = (T)cache[key];

                return result;
            }
            else
            {
                return default(T);
            }
        }

        /// <summary>
        /// Remove item from cache
        /// </summary>
        /// <param name="cacheKey"></param>
        public static void Remove(String cacheKey)
        {
            cache.Remove(cacheKey);
        }
    }
}
