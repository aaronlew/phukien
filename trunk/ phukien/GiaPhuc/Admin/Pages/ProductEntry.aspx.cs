using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using GiaPhuc.Utility;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using System.Web.UI.WebControls;
using phukienipadx.Core;

namespace GiaPhuc.Admin.Pages
{
    public partial class PagesProductEntry : System.Web.UI.Page
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
                //LoadManufacturers();

                var product = ProductImpl.GetProductDetails(ProductId);

                if (null == product)
                {
                    LoadCategories();

                    this.chkActive.Checked = true;
                }
                else
                {
                    LoadCategories(product.CategoryIds);

                    this.txtProductCode.Text = product.ProductNumber;
                    this.txtDiscountPrice.Text = product.DiscountPrice.ToString("#,##0.##");
                    this.txtPrice.Text = product.Price.ToString("#,##0.##");
                    this.imgProduct.ImageUrl = product.ImageUrl;
                    this.imgProduct.AlternateText = product.ImageOriginalUrl;
                    //if(!string.IsNullOrEmpty(product.ImagesOfProductHtml))
                    //{
                    //    string[] imageUrls = product.ImagesOfProductHtml.Split(';');
                    //    this.imgProduct1.ImageUrl = imageUrls[0];
                    //    if (imageUrls.Length > 1) this.imgProduct2.ImageUrl = imageUrls[1];
                    //    if (imageUrls.Length > 2) this.imgProduct3.ImageUrl = imageUrls[2];
                    //}

                    this.chkIsCall.Checked = product.IsCalledPrice;
                    this.chkActive.Checked = product.IsActive;
                    this.chkIsSpecial.Checked = product.IsSpecItem;
                    this.chkIsDiscount.Checked = product.IsDiscountItem;

                    this.txtProductName.Text = product.ProductName;
                    this.txtProducts_Images.Text = product.ImagesOfProductHtml;
                    this.txtProducts_Description.Text = product.SpecificationHtml;
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

                using (Stream outFile = System.IO.File.OpenWrite(path))
                {
                    CopyStream(fileUpload.FileContent, outFile);
                }

                Bitmap srcImage = new Bitmap(fileUpload.FileContent);
                Bitmap newImage = ScaleImage(srcImage, 210, 140);
                newImage.Save(thumbnailsPath);

                return fileName;
            }

            return this.imgProduct.AlternateText;
        }

        private Bitmap ScaleImage(Bitmap srcImage, int newWidth, int newHeight)
        {
            Bitmap newImage = new Bitmap(newWidth, newHeight);
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
            try
            {
                decimal price, discountPrice;
                decimal.TryParse(this.txtPrice.Text, out price);
                decimal.TryParse(this.txtDiscountPrice.Text, out discountPrice);

                var productModel = new ProductInfo
                                       {
                                           ProductId = ProductId,
                                           ProductNumber = this.txtProductCode.Text,
                                           DiscountPrice = discountPrice,
                                           Price = price,
                                           IsCalledPrice = this.chkIsCall.Checked,
                                           IsActive = this.chkActive.Checked,
                                           IsSpecItem = this.chkIsSpecial.Checked,
                                           IsDiscountItem = this.chkIsDiscount.Checked,
                                           ProductName = this.txtProductName.Text,
                                           SpecificationHtml = this.txtProducts_Description.Text,
                                           ImagesOfProductHtml = this.txtProducts_Images.Text,
                                           ManufacturerId = 0,
                                           CategoryIds = new List<int>()
                                       };

                foreach (ListItem item in chklCategory.Items)
                {
                    if(item.Selected)
                    {
                        int categoryId = int.Parse(item.Value);
                        productModel.CategoryIds.Add(categoryId);

                        if (SessionManager.Categories.Any(x => x.CategoryId == categoryId)) // root
                        {
                            productModel.CategoryId = categoryId;
                        }
                    }
                }

                if (productModel.ManufacturerId == 0)
                {
                    productModel.ManufacturerId = null;
                }

                string fileName = UploadImageFile(uplProductImage, this.txtProductCode.Text);
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
            catch
            {
                throw;
            }
        }

        #region Private Methods
        /// <summary> 
        /// Copies the contents of input to output. Doesn't close either stream. 
        /// </summary> 
        private void CopyStream(Stream input, Stream output)
        {
            var buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }

        private void LoadCategories(IList<int> selectedCategoryIds = null)
        {
            foreach (var cate in CategoryImpl.GetCategories())
            {
                var listItem = new ListItem(cate.Name, cate.CategoryId.ToString(CultureInfo.InvariantCulture));
                listItem.Attributes.Add("style",
                                        cate.ParentId > 0 ? "padding-left: 20px" : "color: blue; font-weight: bold");

                listItem.Attributes.Add("parent-id", cate.ParentId.ToString(CultureInfo.InvariantCulture));

                if (selectedCategoryIds != null && selectedCategoryIds.Any(x => x == cate.CategoryId))
                {
                    listItem.Selected = true;
                    listItem.Attributes["style"] += ";background-color: yellow";
                }

                this.chklCategory.Items.Add(listItem);
            }
        }

        #endregion

    }
}