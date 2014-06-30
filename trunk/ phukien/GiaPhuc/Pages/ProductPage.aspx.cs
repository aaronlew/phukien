using System;
using System.Collections.Generic;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Pages
{
    public partial class ProductPage : ParentPage
    {
        #region Members & Properties

        // Old ID
        public string ID
        {
            get
            {
                object val = RouteValue("id");
                if (val == null) return null;
                return val.ToString();
            }
        }

        public string Url
        {
            get
            {
                object val = RouteValue("url");
                if (val == null) return null;
                return val.ToString();
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ID != null)
                {
                    Response.Status = "301 Moved Permanently";
                    Response.AddHeader("Location", "/san-pham/" + ProductImpl.GetProductUrl(int.Parse(ID)));
                    Response.End();
                }

                ProductInfo productModel = ProductImpl.GetProductDetails(Url);

                if (null != productModel)
                {
                    lblPrice.Text = productModel.DisplayPrice;
                    ProductImage.ImageUrl = productModel.ImageUrl;
                    linkProductImage.NavigateUrl = productModel.ImageUrl;

                    Title = string.Concat("CỬA HÀNG TINH TẾ (NICE STORE) - PHỤ KIỆN IPAD - ", productModel.ProductName);
                    lblProductCode.Text = productModel.ProductNumber;
                    lblProductName.Text = productModel.ProductName;
                    linkProductImage.ToolTip = productModel.ProductName;
                    divProductImages.InnerHtml = productModel.ImagesOfProductHtml;
                    divProductInstruction.InnerHtml = productModel.SpecificationHtml;
                    hypBuy.NavigateUrl = productModel.ShopCartUrl;
                    linkBuy.NavigateUrl = productModel.ShopCartUrl;

                    IList<ProductInfo> productInfoList =
                        ProductImpl.GetProductsInTheSameCategory(productModel.CategoryId);
                    if (productInfoList.Count > 0)
                    {
                        dtlProducts.CategoryName = "Có thể bạn quan tâm";
                        dtlProducts.DataSource = productInfoList;
                    }
                }
            }
        }
    }
}