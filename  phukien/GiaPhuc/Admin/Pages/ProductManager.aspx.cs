using System;
using System.Collections.Generic;
using System.Web.Services;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Admin.Pages
{
    public partial class Pages_ProductManager : System.Web.UI.Page
    {
        [WebMethod(EnableSession = true)]
        public static object GetProductList(int jtStartIndex = 0, int jtPageSize = 0, string jtSorting = null)
        {
            try
            {
                //Get data from database
                int totalRecordCount;
                IList<ProductInfo> products = ProductImpl.GetProductsPaging(jtStartIndex, jtPageSize, out totalRecordCount);
                //Return result to jTable
                return new { Result = "OK", Records = products, TotalRecordCount = totalRecordCount };
            }
            catch (Exception ex)
            {
                return new { Result = "ERROR", Message = ex.Message };
            }
        }

        [WebMethod(EnableSession = true)]
        public static object DeleteProductItem(int ProductId)
        {
            try
            {
                if (ProductImpl.DeleteProduct(ProductId))
                    return new { Result = "OK" };
                else
                {
                    return new { Result = "ERROR", Message = "Delete failed." };
                }
            }
            catch (Exception ex)
            {
                return new { Result = "ERROR", Message = ex.Message };
            }
        }
    }
}