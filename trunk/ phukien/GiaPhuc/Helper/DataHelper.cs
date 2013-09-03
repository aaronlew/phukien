using GiaPhuc.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.IO;

namespace GiaPhuc.Helper
{
    public class DataHelper
    {
        protected static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //products = from item in queryProducts
        //           where item.x.MasterCategoriesID == CategoryID
        //           select new ProductModel
        //           {
        //               ProductID = item.x.ProductsID,
        //               ProductCode = item.x.ProductsModel,
        //               ProductName = item.y.ProductsName,
        //               Price = item.x.ProductsPrice,
        //               IsCalledPrice = Convert.ToBoolean(item.x.ProductIsCall),
        //               Specification = item.y.ProductsDescription1,
        //               ImagePath = item.x.ProductsImage,
        //               Url = ("/Pages/ProductDetail.aspx?ID=" + item.x.ProductsID).ParseSimpleURL(item.y.ProductsName),
        //               CartUrl = ("/Pages/CartPage.aspx?ProductID=" + item.x.ProductsID).ParseSimpleURL(item.y.ProductsName),
        //               CategoryID = item.x.MasterCategoriesID,
        //               ClassNew = Convert.ToBoolean(item.x.ProductIsFree) ? "new" : String.Empty,
        //               ClassHot = Convert.ToBoolean(item.x.ProductIsAlwaysFreeShipping) ? "hot" : String.Empty
        //           };
        /// <summary>
        /// Read template
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public static string ReadTemplateFile(string FilePath)
        {
            string tempReadTemplate = String.Empty;
            if (File.Exists(FilePath))
            {
                StreamReader objStreamReader = null;
                objStreamReader = File.OpenText(FilePath);
                string contents = objStreamReader.ReadToEnd().ToString();
                objStreamReader.Close();
                tempReadTemplate = contents;
            }
            return tempReadTemplate;
        }
    }
}