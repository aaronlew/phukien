﻿using System;
using System.Collections.Generic;
using System.Linq;
using phukienipadx.Bl.Models;
using phukienipadx.Dal;
using phukienipadx.Dal.Repository;

namespace phukienipadx.Bl
{
    public class ProductImpl
    {
        public static IList<ProductInfo> GetAllDiscountProducts()
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();

            var queryProducts = (from x in productRep.GetAllproducts()
                                 join y in productDescriptionRep.GetAllproducts_descriptions()
                                     on x.products_id equals y.products_id
                                 select new { x, y });

            // Get new product list
            return (from item in queryProducts
                    where Convert.ToBoolean(item.x.products_discount_type)
                    select new ProductInfo(item.x, item.y)).Take(5).ToList();
        }

        public static IList<ProductInfo> GetAllSpecProducts()
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();

            var queryProducts = (from x in productRep.GetAllproducts()
                                 join y in productDescriptionRep.GetAllproducts_descriptions()
                                     on x.products_id equals y.products_id
                                 select new { x, y });

            // Get new product list
            return (from item in queryProducts
                    where Convert.ToBoolean(item.x.product_is_always_free_shipping)
                    select new ProductInfo(item.x, item.y)).Take(5).ToList();
        }

        public static IList<ProductInfo> GetProductsPaging(int startIndex, int pageSize, out int totalRecords)
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();

            var allProducts = productRep.GetAllproducts();

            totalRecords = allProducts.Count();
            return
                (from x in
                     allProducts.OrderBy(x => x.products_model).Skip(startIndex).Take(pageSize)
                     .ToList()
                 join y in productDescriptionRep.GetAllproducts_descriptions()
                     on x.products_id equals y.products_id
                 select new ProductInfo(x, y)).ToList();
        }

        public static IList<ProductInfo> GetProductsByCategory(int categoryId)
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();

            return (from x in productRep.GetAllproducts()
                    join y in productDescriptionRep.GetAllproducts_descriptions()
                        on x.products_id equals y.products_id
                    where x.master_categories_id == categoryId
                    select new ProductInfo(x, y)).ToList();
        }

        public static ProductInfo GetProductDetails(int productId)
        {
            var productRep = new productsRepository();

            var product = productRep.GetSingleproducts(x => x.products_id == productId);
            if (product != null)
            {
                var productDescriptionRep = new products_descriptionsRepository();
                var productToCategoryRep = new products_to_categoriesRepository();

                var description =
                    productDescriptionRep.GetSingleproducts_descriptions(
                        x => x.products_id == productId && x.language_id == 0);

                var productToCategories = productToCategoryRep.Findproducts_to_categories(
                    x => x.products_id == productId).Select(x => x.categories_id);

                return new ProductInfo(product, description) { CategoryIds = productToCategories.ToList() };
            }

            return null;
        }


        public static IList<ProductInfo> GetProductsInTheSameCategory(int categoryId)
        {
            IList<ProductInfo> products = null;

            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();

            // Load the product in the same category
            products = (from x in productRep.GetAllproducts()
                        join y in productDescriptionRep.GetAllproducts_descriptions()
                        on x.products_id equals y.products_id
                        orderby new Guid()
                        where x.master_categories_id == categoryId
                        orderby x.products_price descending
                        select new ProductInfo(x, y)).Take(12).ToList();

            return products;
        }

        public static bool DeleteProduct(int productId)
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();
            var productToCategoryRep = new products_to_categoriesRepository();

            try
            {
                var product = productRep.GetSingleproducts(x => x.products_id == productId);

                if (null != product)
                {
                    // Delete all descriptions
                    var descriptions = productDescriptionRep.Findproducts_descriptions(x => x.products_id == productId);
                    productDescriptionRep.DeleteBatchproducts_descriptions(descriptions);

                    productToCategoryRep.DeleteAllCategories(x => x.products_id == product.products_id);

                    // Delete product item
                    productRep.Deleteproducts(product);
                
                    productDescriptionRep.Commit();
                    productToCategoryRep.Commit();
                    productRep.Commit();
                }

                return true;
            }
            catch
            {
                throw;
            }
        }

        public static bool InsertProduct(ProductInfo productInfo)
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();

            try
            {

                products product;
                products_descriptions description;

                productInfo.PopInfo(out product, out description);

                productRep.Addproducts(product);
                productRep.Commit();

                productDescriptionRep.Addproducts_descriptions(description);
                productDescriptionRep.Commit();

                if (productInfo.CategoryIds != null && productInfo.CategoryIds.Count > 0)
                {
                    var productToCategoryRep = new products_to_categoriesRepository();
                    foreach (var categoryId in productInfo.CategoryIds)
                    {
                        productToCategoryRep.Addproducts_to_categories(new products_to_categories
                                                                           {
                                                                               products_id = product.products_id,
                                                                               categories_id = categoryId
                                                                           });
                    }
                    productToCategoryRep.Commit();
                }

                return true;
            }
            catch
            {
                throw;
            }
        }

        public static bool UpdateProduct(ProductInfo productInfo)
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();
            var productToCategoryRep = new products_to_categoriesRepository();

            try
            {
                products product = productRep.GetSingleproducts(x => x.products_id == productInfo.ProductId);
                products_descriptions description =
                    productDescriptionRep.GetSingleproducts_descriptions(x => x.products_id == productInfo.ProductId);

                productInfo.MapInfo(product, description);

                productRep.Updateproducts(product);
                productRep.Commit();

                productDescriptionRep.Updateproducts_descriptions(description);
                productDescriptionRep.Commit();

                productToCategoryRep.DeleteAllCategories(x => x.products_id == product.products_id);
                if (productInfo.CategoryIds != null && productInfo.CategoryIds.Count > 0)
                {
                    foreach (var categoryId in productInfo.CategoryIds)
                    {
                        productToCategoryRep.Addproducts_to_categories(new products_to_categories
                        {
                            products_id = product.products_id,
                            categories_id = categoryId
                        });
                    }
                }
                productToCategoryRep.Commit();

                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
