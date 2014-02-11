using System;
using GiaPhuc.Helper;
using GiaPhuc.Utility;
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
                var val = RouteValue("id");
                if (val == null) return null;
                return val.ToString();
            }
        }

        public string Url
        {
            get
            {
                var val = RouteValue("url");
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
                    this.lblPrice.Text = productModel.DisplayPrice;
                    this.ProductImage.ImageUrl = productModel.ImageUrl;
                    this.linkProductImage.NavigateUrl = productModel.ImageUrl;

                    this.Title = string.Concat("CỬA HÀNG TINH TẾ (NICE STORE) - PHỤ KIỆN IPAD - ", productModel.ProductName);
                    this.lblProductCode.Text = productModel.ProductNumber;
                    this.lblProductName.Text = productModel.ProductName;
                    this.linkProductImage.ToolTip = productModel.ProductName;
                    this.divProductImages.InnerHtml = productModel.ImagesOfProductHtml;
                    this.divProductInstruction.InnerHtml = productModel.SpecificationHtml;
                    this.hypBuy.NavigateUrl = productModel.ShopCartUrl;
                    this.linkBuy.NavigateUrl = productModel.ShopCartUrl;

                    var productInfoList = ProductImpl.GetProductsInTheSameCategory(productModel.CategoryId);
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