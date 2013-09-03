using System;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Pages
{
    public partial class ProductDetail : System.Web.UI.Page
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
                    // productModel.BuildManufacturer(ManufacturerHelper.GetManufacturers());
                    // this.lblManufacturers.Text = productModel.Manufacturer;

                    dtlProducts.DataSource = ProductImpl.GetProductsInTheSameCategory(productModel.ProductId);
                }
            }
        }
    }
}