using System.Collections.Generic;
using System.Web;
using GiaPhuc.App_Data;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using System;
using System.Web.Caching;

namespace GiaPhuc.Utility
{
    public class SessionUtils
    {
        #region Common Methods
        public static T Get<T>(string key)
        {
            if (Exist(key))
                return (T)HttpContext.Current.Session[key];
            return default(T);
        }

        public static void Set<T>(string key, T val)
        {
            HttpContext.Current.Session[key] = val;
        }

        public static void Clear(string key)
        {

            HttpContext.Current.Session.Remove(key);
        }

        public static void Clear()
        {
            HttpContext.Current.Session.Clear();
        }

        public static bool Exist(string key)
        {
            return HttpContext.Current.Session[key] != null;
        }
        #endregion
    }

    public class CacheUtils
    {
        #region Common Methods
        public static T Get<T>(string key)
        {
            if (Exist(key))
                return (T)HttpContext.Current.Cache[key];
            return default(T);
        }

        public static void Set<T>(string key, T val)
        {
            HttpContext.Current.Cache[key] = val;
        }

        public static void Set<T>(string key, int cacheMinutes, T val)
        {
            HttpContext.Current.Cache.Add(key, val, null, DateTime.Now.AddMinutes(cacheMinutes), Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }

        public static void Clear(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        /// <summary>
        /// Clear all
        /// </summary>
        public static void Clear()
        {

        }

        public static bool Exist(string key)
        {
            return HttpContext.Current.Cache[key] != null;
        }
        #endregion
    }

    public class SessionManager
    {
        public static IDictionary<int, ShopCart> Cart
        {
            get
            {
                if (!SessionUtils.Exist("Cart"))
                {
                    SessionUtils.Set("Cart", new Dictionary<int, ShopCart>());
                }
                return SessionUtils.Get<IDictionary<int, ShopCart>>("Cart");
            }
            set { SessionUtils.Set("Cart", value); }
        }

        public static IList<CategoryInfo> Categories
        {
            get
            {
                if (!CacheUtils.Exist("Categories"))
                {
                    CacheUtils.Set("Categories", 2, CategoryImpl.GetHierarchyCategories());
                }
                return CacheUtils.Get<IList<CategoryInfo>>("Categories");
            }
        }

        public static IList<PageInfo> Topics
        {
            get
            {
                if (!CacheUtils.Exist("Topics"))
                {
                    CacheUtils.Set("Topics", 5, PostImpl.GetTopics());
                }
                return CacheUtils.Get<IList<PageInfo>>("Topics");
            }
        }

        public static IList<CategoryInfo> AllCategories
        {
            get
            {
                if (!CacheUtils.Exist("AllCategories"))
                {
                    CacheUtils.Set("AllCategories", 2, CategoryImpl.GetAllProductInCategory());
                }
                return CacheUtils.Get<IList<CategoryInfo>>("AllCategories");
            }
        }

        public static IList<ProductInfo> SpecProducts
        {
            get
            {
                if (!CacheUtils.Exist("SpecProducts"))
                {
                    CacheUtils.Set("SpecProducts", ProductImpl.GetAllSpecProducts());
                }
                return CacheUtils.Get<IList<ProductInfo>>("SpecProducts");
            }
        }

        public static IList<ProductInfo> DiscountProducts
        {
            get
            {
                if (!CacheUtils.Exist("DiscountProducts"))
                {
                    CacheUtils.Set("DiscountProducts", ProductImpl.GetAllDiscountProducts());
                }
                return CacheUtils.Get<IList<ProductInfo>>("DiscountProducts");
            }
        }
    }
}