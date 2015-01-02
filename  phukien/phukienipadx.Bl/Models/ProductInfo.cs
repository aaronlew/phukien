using System;
using System.Collections.Generic;
using System.IO;
using phukienipadx.Core;
using phukienipadx.Core.Utilities;
using phukienipadx.Dal;

namespace phukienipadx.Bl.Models
{
    public class ProductInfo
    {
        private const string DetailLink = "/san-pham/{0}";
        private const string CartLink = "/gio-hang/{0}";

        public ProductInfo()
        {
        }

        public ProductInfo(products product)
        {
            CategoryId = product.master_categories_id;
            ManufacturerId = product.manufacturers_id;
            ProductId = product.products_id;
            ProductNumber = product.products_model;
            ImageUrl = product.products_image;

            DiscountPrice = product.products_price_sorter;
            Price = product.products_price;
            IsCalledPrice = Convert.ToBoolean(product.product_is_call);
            IsSpecItem = Convert.ToBoolean(product.product_is_always_free_shipping);
            IsDiscountItem = Convert.ToBoolean(product.products_discount_type);
            IsActive = Convert.ToBoolean(product.products_status);

            DisplayDiscountPrice = string.Format("<span itemprop='price'>{0:n0}</span>đ", DiscountPrice);
            DisplayPrice = IsCalledPrice ? "Call" : string.Format("<span itemprop='price'>{0:n0}</span>đ", Price);
        }

        public ProductInfo(product product)
        {
            CategoryId = product.master_categories_id;
            ManufacturerId = product.manufacturers_id;
            ProductId = product.products_id;
            ProductNumber = product.products_model;
            ImageUrl = product.products_image;

            DiscountPrice = product.products_price_sorter;
            Price = product.products_price;
            IsCalledPrice = Convert.ToBoolean(product.product_is_call);
            IsSpecItem = Convert.ToBoolean(product.product_is_always_free_shipping);
            IsDiscountItem = Convert.ToBoolean(product.products_discount_type);
            IsActive = Convert.ToBoolean(product.products_status);

            DisplayDiscountPrice = string.Format("<span itemprop='price'>{0:n0}</span>đ", DiscountPrice);
            DisplayPrice = IsCalledPrice ? "Call" : string.Format("<span itemprop='price'>{0:n0}</span>đ", Price);
        }

        public ProductInfo(products product, products_descriptions description)
            : this(product)
        {
            ProductName = description.products_name;
            SpecificationHtml = description.products_description1.RemoveBadCode();
            ImagesOfProductHtml = description.products_images.RemoveBadCode();
            OriginalUrl = description.products_url;
            DetailsUrl = string.Format(DetailLink, description.products_url);
            ShopCartUrl = string.Format(CartLink, description.products_url);

            ImageOriginalUrl = product.products_image.RemoveBadCode();
            if (ImageOriginalUrl != null)
            {
                ImageOriginalUrl = ImageOriginalUrl.Substring(ImageOriginalUrl.LastIndexOf('/') + 1);
                ImageUrl = Path.Combine(Define.UploadFolder, ImageOriginalUrl);
                ThumbsUrl = Path.Combine(Define.ThumbsFolder, ImageOriginalUrl);
            }
        }

        public ProductInfo(product product, products_description description)
            : this(product)
        {
            ProductName = description.products_name;
            SpecificationHtml = description.products_description1.RemoveBadCode();
            ImagesOfProductHtml = description.products_images.RemoveBadCode();
            OriginalUrl = description.products_url;
            DetailsUrl = string.Format(DetailLink, description.products_url);
            ShopCartUrl = string.Format(CartLink, description.products_url);

            ImageOriginalUrl = product.products_image.RemoveBadCode();
            if (ImageOriginalUrl != null)
            {
                ImageOriginalUrl = ImageOriginalUrl.Substring(ImageOriginalUrl.LastIndexOf('/') + 1);
                ImageUrl = Path.Combine(Define.UploadFolder, ImageOriginalUrl);
                ThumbsUrl = Path.Combine(Define.ThumbsFolder, ImageOriginalUrl);
            }
        }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int? ManufacturerId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public string ImageOriginalUrl { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbsUrl { get; set; }
        public string OriginalUrl { get; set; }
        public string DetailsUrl { get; set; }
        public string ShopCartUrl { get; set; }
        public string SpecificationHtml { get; set; }
        public string ImagesOfProductHtml { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal Price { get; set; }
        public bool IsCalledPrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsSpecItem { get; set; }
        public bool IsDiscountItem { get; set; }

        public string DisplayDiscountPrice { get; set; }
        public string DisplayPrice { get; set; }

        public IList<int> CategoryIds { get; set; }


        public void PopInfo(out products product)
        {
            product = new products
            {
                master_categories_id = CategoryId,
                manufacturers_id = ManufacturerId,
                products_model = ProductNumber,
                products_image = ImageOriginalUrl,
                products_price_sorter = DiscountPrice,
                products_price = Price,
                product_is_call = Convert.ToSByte(IsCalledPrice),
                product_is_always_free_shipping = Convert.ToSByte(IsSpecItem),
                products_discount_type = Convert.ToSByte(IsDiscountItem),
                products_status = Convert.ToSByte(IsActive)
            };
        }

        public void PopInfo(out products product, out products_descriptions description)
        {
            PopInfo(out product);

            description = new products_descriptions
            {
                products_name = ProductName,
                products_description1 = SpecificationHtml,
                products_images = ImagesOfProductHtml,
                products_url = DetailsUrl
            };
        }

        public void MapInfo(products product)
        {
            product.master_categories_id = CategoryId;
            product.manufacturers_id = ManufacturerId;
            product.products_model = ProductNumber;
            product.products_image = ImageOriginalUrl;

            product.products_price = Price;
            product.products_price_sorter = DiscountPrice;
            product.products_discount_type = Convert.ToSByte(IsDiscountItem);
            product.product_is_call = Convert.ToSByte(IsCalledPrice);
            product.product_is_always_free_shipping = Convert.ToSByte(IsSpecItem);
            product.products_status = Convert.ToSByte(IsActive);
        }

        public void MapInfo(products product, products_descriptions description)
        {
            MapInfo(product);

            description.products_name = ProductName;
            description.products_description1 = SpecificationHtml;
            description.products_images = ImagesOfProductHtml;
            description.products_url = DetailsUrl;
        }
    }
}