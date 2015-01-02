using System;
using System.Collections.Generic;
using System.Web.UI;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Pages
{
    public partial class ProductDetail : Page
    {
        private int ProductId
        {
            get
            {
                if (null != Request["ID"])
                {
                    return int.Parse(Request["ID"]);
                }
                return 0;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductInfo productModel = ProductImpl.GetProductDetails(ProductId);

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
                    // productModel.BuildManufacturer(ManufacturerHelper.GetManufacturers());
                    // this.lblManufacturers.Text = productModel.Manufacturer;

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