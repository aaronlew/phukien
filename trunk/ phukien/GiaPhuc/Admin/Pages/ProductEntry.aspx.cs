using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using phukienipadx.Core;
using phukienipadx.Core.Utilities;

namespace GiaPhuc.Admin.Pages
{
    public partial class PagesProductEntry : Page
    {
        private int ProductId
        {
            get
            {
                if (null != Request["id"])
                {
                    return int.Parse(Request["id"]);
                }
                return 0;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //LoadManufacturers();

                ProductInfo product = ProductImpl.GetProductDetails(ProductId);

                if (null == product)
                {
                    LoadCategories();

                    chkActive.Checked = true;
                }
                else
                {
                    LoadCategories(product.CategoryIds);

                    ddlHomeCategories.SelectedValue = product.CategoryId.ToString(CultureInfo.InvariantCulture);

                    txtProductCode.Text = product.ProductNumber;
                    txtDiscountPrice.Text = product.DiscountPrice.ToString("#,##0.##");
                    txtPrice.Text = product.Price.ToString("#,##0.##");
                    imgProduct.ImageUrl = product.ImageUrl;
                    imgProduct.AlternateText = product.ImageOriginalUrl;

                    chkIsCall.Checked = product.IsCalledPrice;
                    chkActive.Checked = product.IsActive;
                    chkIsSpecial.Checked = product.IsSpecItem;
                    chkIsDiscount.Checked = product.IsDiscountItem;

                    txtProductName.Text = product.ProductName;
                    txtProducts_Images.Text = product.ImagesOfProductHtml;
                    txtProducts_Description.Text = product.SpecificationHtml;
                }
            }
        }

        private string UploadImageFile(FileUpload fileUpload, string productCode)
        {
            if (fileUpload.HasFile)
            {
                string extension = fileUpload.FileName.Substring(fileUpload.FileName.IndexOf('.'));
                string fileName = string.Format("{0}-{1:yyMMddhhmmss}{2}", productCode, DateTime.Now, extension);
                string path = Server.MapPath(Path.Combine(Define.UploadFolder, fileName));
                string thumbnailsPath = Server.MapPath(Path.Combine(Define.ThumbsFolder, fileName));

                // Remove mark

                using (Stream outFile = File.OpenWrite(path))
                {
                    CopyStream(fileUpload.FileContent, outFile);
                }

                var srcImage = new Bitmap(fileUpload.FileContent);
                Bitmap newImage = ScaleImage(srcImage, 210, 140);
                newImage.Save(thumbnailsPath);

                return fileName;
            }

            return imgProduct.AlternateText;
        }

        private Bitmap ScaleImage(Bitmap srcImage, int newWidth, int newHeight)
        {
            var newImage = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
            }

            return newImage;
        }

        protected void LnkSaveClick(object sender, EventArgs e)
        {
            decimal price, discountPrice;
            decimal.TryParse(txtPrice.Text, out price);
            decimal.TryParse(txtDiscountPrice.Text, out discountPrice);

            var productModel = new ProductInfo
            {
                ProductId = ProductId,
                ProductNumber = txtProductCode.Text,
                DiscountPrice = discountPrice,
                Price = price,
                DetailsUrl = StringUtils.GetGoodUrl(txtProductName.Text),
                IsCalledPrice = chkIsCall.Checked,
                IsActive = chkActive.Checked,
                IsSpecItem = chkIsSpecial.Checked,
                IsDiscountItem = chkIsDiscount.Checked,
                ProductName = txtProductName.Text,
                SpecificationHtml = txtProducts_Description.Text,
                ImagesOfProductHtml = txtProducts_Images.Text,
                ManufacturerId = 0,
                CategoryId = int.Parse(ddlHomeCategories.SelectedValue),
                CategoryIds = new List<int>()
            };

            foreach (ListItem item in chklCategory.Items)
            {
                if (item.Selected)
                {
                    int categoryId = int.Parse(item.Value);
                    productModel.CategoryIds.Add(categoryId);

                    //if (SessionManager.Categories.Any(x => x.CategoryId == categoryId)) // root
                    //{
                    //    productModel.CategoryId = categoryId;
                    //}
                }
            }

            if (productModel.ManufacturerId == 0)
            {
                productModel.ManufacturerId = null;
            }

            string fileName = UploadImageFile(uplProductImage, txtProductCode.Text);
            if (fileName != null) productModel.ImageOriginalUrl = fileName;

            //var builder = new StringBuilder();
            //string fileName1 = UploadImageFile(FileUpload1, this.txtProductCode.Text);
            //if (fileName1 != null) builder.Append(fileName1);

            //string fileName2 = UploadImageFile(FileUpload2, this.txtProductCode.Text);
            //if (fileName2 != null)
            //{
            //    if (builder.Length > 0) builder.Append(';');
            //    builder.Append(fileName2);
            //}

            //string fileName3 = UploadImageFile(FileUpload3, this.txtProductCode.Text);
            //if (fileName3 != null)
            //{
            //    if (builder.Length > 0) builder.Append(';');
            //    builder.Append(fileName3);
            //}

            //if (builder.Length > 0) productModel.ImagesOfProductHtml = builder.ToString();

            if (ProductId == 0)
            {
                if (ProductImpl.InsertProduct(productModel))
                {
                    // Continues insert new entry
                    Response.Redirect("/Admin/Pages/ProductEntry.aspx");
                }
            }
            else
            {
                if (ProductImpl.UpdateProduct(productModel))
                {
                    Response.Redirect("/Admin/Pages/ProductManager.aspx");
                }
            }
        }

        #region Private Methods

        /// <summary>
        ///     Copies the contents of input to output. Doesn't close either stream.
        /// </summary>
        private void CopyStream(Stream input, Stream output)
        {
            var buffer = new byte[8*1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }

        private void LoadCategories(IList<int> selectedCategoryIds = null)
        {
            IList<CategoryInfo> cates = CategoryImpl.GetCategories();
            ddlHomeCategories.DataSource = cates;
            ddlHomeCategories.DataTextField = "Name";
            ddlHomeCategories.DataValueField = "CategoryId";
            ddlHomeCategories.DataBind();

            foreach (CategoryInfo cate in cates)
            {
                var listItem = new ListItem(cate.Name, cate.CategoryId.ToString(CultureInfo.InvariantCulture));
                listItem.Attributes.Add("style",
                    cate.ParentId > 0 ? ("padding-left: " + cate.Level * 20 + "px") : "color: blue; font-weight: bold");

                listItem.Attributes.Add("parent-id", cate.ParentId.ToString(CultureInfo.InvariantCulture));

                if (selectedCategoryIds != null && selectedCategoryIds.Any(x => x == cate.CategoryId))
                {
                    listItem.Selected = true;
                    listItem.Attributes["style"] += ";background-color: yellow";
                }

                chklCategory.Items.Add(listItem);
            }
        }

        #endregion
    }
}