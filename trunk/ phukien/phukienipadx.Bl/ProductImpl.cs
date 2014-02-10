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

        public static IList<ProductInfo> GetProductsPaging(string status, string keyword, int? pageNumber, int? pageSize, out int totalRecords, out int countPosted, out int countDeleted)
        {
            totalRecords = 0;
            countPosted = 0;
            countDeleted = 0;

            using (var db = new phukienipadxContext())
            {

                IQueryable<product> query = (from x in db.products select x);

                if (!string.IsNullOrEmpty(keyword))
                {
                    var categoriesId = db.categories_descriptions.Where(x => x.categories_name.Contains(keyword)).Select(x => x.categories_id);
                    var productsId = db.products_to_categories.Where(x => categoriesId.Any(y => y == x.categories_id)).Select(x => x.products_id).ToList();
                    query = query.Where(x => productsId.Contains(x.products_id) || x.products_model.Contains(keyword));
                }
                switch (status)
                {
                    case "posted":
                        query = query.Where(x => x.products_status == 1);
                        break;
                    case "deleted":
                        query = query.Where(x => x.products_status != 1);
                        break;
                }

                totalRecords = query.Count();
                query = query.OrderBy(x => x.products_model);
                if (pageNumber.HasValue && pageSize.HasValue)
                    query = query.PageIQuery(pageNumber.Value, pageSize.Value);

                return (from x in query
                        join y in db.products_descriptions
                     on x.products_id equals y.products_id
                        select new ProductInfo(x, y)).ToList();
            }
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

        public static string GetProductUrl(int id)
        {
            var productDescriptionRep = new products_descriptionsRepository();
            var description =
                productDescriptionRep.GetSingleproducts_descriptions(
                    x => x.products_id == id && x.language_id == 0);
            if (description != null) return description.products_url;

            return null;
        }

        public static ProductInfo GetProductDetails(string url)
        {
            var productDescriptionRep = new products_descriptionsRepository();
            var description =
                productDescriptionRep.GetSingleproducts_descriptions(
                    x => x.products_url == url && x.language_id == 0);

            if (description != null)
            {
                var productRep = new productsRepository();
                var productToCategoryRep = new products_to_categoriesRepository();

                var product = productRep.GetSingleproducts(x => x.products_id == description.products_id);
                var productToCategories = productToCategoryRep.Findproducts_to_categories(
                    x => x.products_id == description.products_id).Select(x => x.categories_id);

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
