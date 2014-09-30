using GiaPhuc.Data;
using System;
using System.Collections.Generic;
using phukienipadx.Core;
using phukienipadx.Core.Utilities;

namespace GiaPhuc.App_Data
{
    public class CategoryBrief
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Deactive { get; set; }

        public List<CategoryBrief> SubCategories { get; set; } 

        public CategoryBrief()
        {

        }
        
        public CategoryBrief(Categories category, CategoriesDescription description)
            : this()
        {
            CategoryID = description.CategoriesID;
            CategoryName = description.CategoriesName;
            Deactive = !Convert.ToBoolean(category.CategoriesStatus);
        }
    }

    public class Category : CategoryBrief
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }

    public class ProductModel
    {
        const string ClassNewItem = "new";
        const string ClassHotItem = "hot";
        const string DetailLink = "/Pages/ProductDetail.aspx?ID={0}";
        const string CartLink = "/Pages/CartPage.aspx?ProductID={0}";

        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int? ManufacturerID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public string ProductPhotos { get; set; }
        public string Specification { get; set; }
        public string Url { get; set; }
        public string CartUrl { get; set; }
        public string ClassNew { get; set; }
        public string ClassHot { get; set; }
        public float UserRating { get; set; }
        public decimal Price { get; set; }
        public bool IsCalledPrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsNewItem { get; set; }
        public bool IsHotItem { get; set; }

        public ProductModel()
        {

        }

        public ProductModel(Products product)
            : this()
        {

            ProductID = product.ProductsID;
            ProductCode = product.ProductsModel;
            Price = product.ProductsPrice;
            CategoryID = product.MasterCategoriesID;
            ManufacturerID = product.ManufacturersID;
            IsCalledPrice = Convert.ToBoolean(product.ProductIsCall);
            IsActive = Convert.ToBoolean(product.ProductsStatus);
            IsNewItem = Convert.ToBoolean(product.ProductIsFree);
            IsHotItem = Convert.ToBoolean(product.ProductIsAlwaysFreeShipping);
            ClassNew = IsNewItem ? ClassNewItem : string.Empty;
            ClassHot = IsHotItem ? ClassHotItem : string.Empty;
        }

        public ProductModel(Products product, ProductsDescription description, bool isSmall = false)
            : this(product)
        {
            ProductName = description.ProductsName;
            Specification = description.ProductsDescription1.RemoveBadCode();
            ProductPhotos = description.ProductsImages.RemoveBadCode();
            string imageUrl = product.ProductsImage.RemoveBadCode();
            imageUrl = imageUrl.Substring(imageUrl.LastIndexOf('/') + 1);
            ImagePath = Define.UploadFolder + imageUrl;
            Url = string.Format(DetailLink, product.ProductsID).ParseSimpleUrl(description.ProductsName);
            CartUrl = string.Format(CartLink, product.ProductsID).ParseSimpleUrl(description.ProductsName);
            IsSmall = isSmall;
        }

        public void UpdateData(Products product, ProductsDescription description)
        {
            product.ProductsID = ProductID;
            product.ProductsModel = ProductCode;
            product.ProductsPrice = Price;
            product.MasterCategoriesID = CategoryID;
            product.ManufacturersID = ManufacturerID;
            product.ProductIsCall = Convert.ToSByte(IsCalledPrice);
            product.ProductsStatus = Convert.ToSByte(IsActive);
            product.ProductIsFree = Convert.ToSByte(IsNewItem);
            product.ProductIsAlwaysFreeShipping = Convert.ToSByte(IsHotItem);
            product.ProductsImage = ImagePath;

            description.ProductsName = ProductName;
            description.ProductsDescription1 = Specification;
            description.ProductsImages = ProductPhotos;
        }

        /// <summary>
        /// This property usually use for the hot or new item.
        /// </summary>
        public bool IsSmall { private get; set; }

        public string Manufacturer { get; set; }

        public void BuildManufacturer(IEnumerable<Manufacturers> manufacturers)
        {
            Manufacturer = String.Empty;
            if (ManufacturerID.HasValue)
            {
                foreach (var item in manufacturers)
                {
                    int value = MathUtil.Pow(2, item.ManufacturersID);
                    if ((ManufacturerID.Value & value) == value)
                    {
                        // Contains
                        Manufacturer += string.Format("<input type='checkbox' value='true' disabled='disabled'>{0}</input>", item.ManufacturersName);
                    }
                }
            }

        }

        private string _priceName = String.Empty;
        public string PriceName
        {
            get
            {
                if (string.IsNullOrEmpty(_priceName))
                {
                    if (IsCalledPrice || Price == 0)
                    {
                        _priceName += "Call";
                    }
                    else
                    {
                        _priceName += System.String.Format("{0:n0} đ", Price);
                    }
                }

                return _priceName;
            }
        }
    }

    public class ShopCart
    {
        public int ProductId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductUrl { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get { return (decimal)Quantity * Price; } }
    }

}