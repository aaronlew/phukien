using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Handler
{
    /// <summary>
    /// Summary description for MyService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MyService : System.Web.Services.WebService
    {
        const int PageSize = 10;
        
        [WebMethod]
        public bool UpdateProduct(ProductInfo product)
        {
            return ProductImpl.UpdateProduct(product);
        }

        [WebMethod]
        public object GetProducts(string status, int pageNumber, string keyword)
        {
            int count, countPosted, countDeleted;
            var list = ProductImpl.GetProductsPaging(status, keyword, pageNumber, PageSize, out count, out countPosted, out countDeleted);

            PostedGridTable<ProductInfo> obj = new PostedGridTable<ProductInfo>
            {
                PageNumber = pageNumber,
                TotalRecords = count,
                PageSize = PageSize,
                List = list,
                CountPosted = countPosted,
                CountDeleted = countDeleted
            };

            return obj;
        }
    }
}

[Serializable]
public class GridTable<T>
{
    public int PageNumber { get; set; }
    public int TotalRecords { get; set; }
    public int PageSize { get; set; }
    public IList<T> List { get; set; }
}

[Serializable]
public class PostedGridTable<T> : GridTable<T>
{
    public int CountPosted { get; set; }
    public int CountDeleted { get; set; }
}