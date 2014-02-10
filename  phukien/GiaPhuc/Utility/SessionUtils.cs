using System.Collections.Generic;
using System.Web;
using GiaPhuc.App_Data;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using System;
using System.Web.Caching;
using MichaelKappel.Net.CSharp;

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

        const string CategoriesConstant = "Categories";
        public static IList<CategoryInfo> Categories
        {
            get
            {
                IList<CategoryInfo> categories = HelperCache.Get<IList<CategoryInfo>>(CategoriesConstant);
                if (categories == null)
                    lock (obj)
                    {
                        if (categories == null)
                        {
                            categories = CategoryImpl.GetHierarchyCategories();
                            HelperCache.Add(CategoriesConstant, categories, HelperCache.CachingTime.ShortTermSliding);
                        }
                    }
                return categories;
            }
        }

        const string TopicsConstant = "Topics";
        public static IList<PageInfo> Topics
        {
            get
            {
                IList<PageInfo> pages = HelperCache.Get<IList<PageInfo>>(TopicsConstant);
                if (pages == null)
                    lock (obj)
                    {
                        if (pages == null)
                        {
                            pages = PostImpl.GetTopics();
                            HelperCache.Add(TopicsConstant, pages, HelperCache.CachingTime.ShortTermSliding);
                        }
                    }
                return pages;
            }
        }

        static object obj = new object();
        const string AllCategoriesConstant = "AllCategories";

        public static IList<CategoryInfo> AllCategories
        {
            get
            {
                IList<CategoryInfo> categories = HelperCache.Get<IList<CategoryInfo>>(AllCategoriesConstant);
                if (categories == null)
                    lock (obj)
                    {
                        if (categories == null)
                        {
                            categories = CategoryImpl.GetAllProductInCategory();
                            HelperCache.Add(AllCategoriesConstant, categories, HelperCache.CachingTime.LongTermSliding);
                        }
                    }
                return categories;
            }
        }

        const string SpecProductsConstant = "SpecProducts";

        public static IList<ProductInfo> SpecProducts
        {
            get
            {
                IList<ProductInfo> products = HelperCache.Get<IList<ProductInfo>>(SpecProductsConstant);
                if (products == null)
                    lock (obj)
                    {
                        if (products == null)
                        {
                            products = ProductImpl.GetAllSpecProducts();
                            HelperCache.Add(SpecProductsConstant, products, HelperCache.CachingTime.LongTermSliding);
                        }
                    }
                return products;
            }
        }

        const string DiscountProductsConstant = "DiscountProducts";

        public static IList<ProductInfo> DiscountProducts
        {
            get
            {
                IList<ProductInfo> products = HelperCache.Get<IList<ProductInfo>>(DiscountProductsConstant);
                if (products == null)
                    lock (obj)
                    {
                        if (products == null)
                        {
                            products = ProductImpl.GetAllDiscountProducts();
                            HelperCache.Add(DiscountProductsConstant, products, HelperCache.CachingTime.LongTermSliding);
                        }
                    }
                return products;
            }
        }
    }
}