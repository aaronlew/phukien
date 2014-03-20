using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using GiaPhuc.App_Data;
using GiaPhuc.Data;
using System.Data;
using GiaPhuc.Helper;
using GiaPhuc.Utility;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using phukienipadx.Core;

namespace GiaPhuc
{
    /// <summary>
    /// Summary description for CMS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CMS : System.Web.Services.WebService
    {
        [WebMethod(EnableSession = true), ScriptMethod]
        public IList<ShopCart> GetCart()
        {
            return SessionManager.Cart.Values.ToList();
        }

        [WebMethod(EnableSession = true), ScriptMethod]
        public void MinusPlusQty(string productId, int qty, bool plus)
        {
            var line = SessionManager.Cart.Values.FirstOrDefault(x => x.ProductNumber == productId);
            if (line != null)
            {
                line.Quantity += plus ? 1 : -1;

                return;
            }

            throw new InvalidOperationException("Qty not valid");
        }

        [WebMethod(EnableSession = true), ScriptMethod]
        public bool RemoveItem(int productId)
        {
            SessionManager.Cart.Remove(productId);
            return true;
        }

        #region Page Methods
        [WebMethod, ScriptMethod]
        public GridTable<PageInfo> LoadPages(int pageNumber)
        {
            int totalRecords;
            var gridTopics = new GridTable<PageInfo>
            {
                PageNumber = pageNumber,
                PageSize = Define.PageSize,
                List = PostImpl.PagingPages(pageNumber, out totalRecords),
                TotalRecords = totalRecords
            };

            return gridTopics;
        }

        [WebMethod, ScriptMethod]
        public bool DeletePage(int id)
        {
            return TopicHelper.DeleteTopic(id);
        }
        #endregion

        #region Post Methods
        [WebMethod, ScriptMethod]
        public GridTable<PageInfo> LoadPosts(int pageNumber)
        {
            int totalRecords;
            var gridTopics = new GridTable<PageInfo>
            {
                PageNumber = pageNumber,
                PageSize = Define.PageSize,
                List = PostImpl.PagingPages(pageNumber, out totalRecords),
                TotalRecords = totalRecords
            };

            return gridTopics;
        }

        [WebMethod, ScriptMethod]
        public bool DeletePost(int id)
        {
            return TopicHelper.DeleteTopic(id);
        }
        #endregion

        #region Product Methods

        [WebMethod, ScriptMethod]
        public bool DeleteProduct(int id)
        {
            return ProductImpl.DeleteProduct(id);
        }
        #endregion

        #region Category Methods

        [WebMethod, ScriptMethod]
        public IList<CategoryInfo> LoadCategories()
        {
            return CategoryImpl.GetCategories();
        }

        [WebMethod, ScriptMethod]
        public GridTable<CategoryInfo> LoadCategories1(int pageNumber)
        {
            const int totalRecords = 0;
            var gridCategories = new GridTable<CategoryInfo>
            {
                PageNumber = pageNumber,
                PageSize = Define.PageSize,
                List = CategoryImpl.GetCategories(),
                TotalRecords = totalRecords
            };

            return gridCategories;
        }

        [WebMethod, ScriptMethod]
        public bool DeleteCategory(int id)
        {
            return CategoryHelper.DeleteCategory(id);
        }
        #endregion

        #region Manufacturer Methods
        [WebMethod, ScriptMethod]
        public GridTable<Manufacturers> LoadManufacturers(int pageNumber)
        {
            const int totalRecords = 0;
            var gridManufacturers = new GridTable<Manufacturers>
            {
                PageNumber = pageNumber,
                PageSize = Define.PageSize,
                List = ManufacturerHelper.GetManufacturers(),
                TotalRecords = totalRecords
            };

            return gridManufacturers;
        }

        [WebMethod, ScriptMethod]
        public bool DeleteManufacturer(int id)
        {
            return ManufacturerHelper.DeleteManufacturer(id);
        }
        #endregion

    }

    public class GridTable<T>
    {
        public int PageNumber { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set; }
        public IList<T> List { get; set; }
    }
}
