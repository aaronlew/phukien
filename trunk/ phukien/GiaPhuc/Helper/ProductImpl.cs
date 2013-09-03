using GiaPhuc.App_Data;
using GiaPhuc.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using GiaPhuc.Utility;

namespace GiaPhuc.Helper
{
    public class ProductImpl : DataHelper
    {

        public static IEnumerable<ProductModel> GetAllNewProducts()
        {
            IEnumerable<ProductModel> products = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var queryProducts = from x in context.Products.ToList()
                                        join y in context.ProductsDescription
                                        on x.ProductsID equals y.ProductsID
                                        select new { x, y };
                    products = from item in queryProducts
                               where Convert.ToBoolean(item.x.ProductIsFree)
                               //orderby new { item.x.MasterCategoriesID, item.x.ProductsPrice }
                               select new ProductModel(item.x, item.y, true);
                }
            }

            return products;
        }

        public static IEnumerable<ProductModel> GetAllHotProducts()
        {
            IEnumerable<ProductModel> products = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var queryProducts = from x in context.Products.ToList()
                                        join y in context.ProductsDescription
                                        on x.ProductsID equals y.ProductsID
                                        select new { x, y };
                    products = from item in queryProducts
                               where Convert.ToBoolean(item.x.ProductIsAlwaysFreeShipping)
                               //orderby new { item.x.MasterCategoriesID, item.x.ProductsPrice }
                               select new ProductModel(item.x, item.y, true);
                }
            }

            return products;
        }

        public static IEnumerable<ProductModel> GetAllDiscountProducts()
        {
            IEnumerable<ProductModel> products = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var queryProducts = from x in context.Products.ToList()
                                        join y in context.ProductsDescription
                                        on x.ProductsID equals y.ProductsID
                                        select new { x, y };
                    products = from item in queryProducts
                               where Convert.ToBoolean(item.x.ProductsDiscountType)
                               //orderby new { item.x.MasterCategoriesID, item.x.ProductsPrice }
                               select new ProductModel(item.x, item.y, true);
                }
            }

            return products;
        }

        /// <summary>
        /// Get all product in category
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Category> GetAllProductInCategory()
        {
            IEnumerable<Category> categories = null;
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var queryProducts = from x in context.Products.ToList()
                                        join y in context.ProductsDescription
                                        on x.ProductsID equals y.ProductsID
                                        select new { x, y };
                    categories = from item in queryProducts
                                 join z in context.CategoriesDescription
                                 on item.x.MasterCategoriesID equals z.CategoriesID
                                 group item by z into g
                                 select new Category
                                 {
                                     CategoryID = g.Key.CategoriesID,
                                     CategoryName = g.Key.CategoriesName,
                                     Products = g.Select(item => new ProductModel(item.x, item.y))
                                 };
                }
            }
            return categories;
        }

        /// <summary>
        /// Get product list in category
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public static IEnumerable<Category> GetProductInCategory(int categoryID)
        {
            IEnumerable<Category> categories = null;
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var queryProducts = from x in context.Products.ToList()
                                        join y in context.ProductsDescription
                                        on x.ProductsID equals y.ProductsID
                                        select new { x, y };
                    categories = from item in queryProducts
                                 where item.x.MasterCategoriesID == categoryID
                                 group item by item.x.MasterCategoriesID into g
                                 select new Category
                                 {
                                     CategoryID = g.Key,
                                     Products = g.Select(item => new ProductModel(item.x, item.y))
                                 };
                }
            }
            return categories;
        }

        /// <summary>
        /// Get product list in category by category id and manufacturer id
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="manufacturerID"> </param>
        /// <returns></returns>
        public static IEnumerable<Category> GetProductInCategory(int categoryID, int manufacturerID)
        {
            IEnumerable<Category> categories = null;
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var queryProducts = from x in context.Products.ToList()
                                        join y in context.ProductsDescription
                                        on x.ProductsID equals y.ProductsID
                                        select new { x, y };
                    categories = from item in queryProducts
                                 where item.x.MasterCategoriesID == categoryID
                                 && (item.x.ManufacturersID & manufacturerID) == manufacturerID
                                 group item by item.x.MasterCategoriesID into g
                                 select new Category
                                 {
                                     CategoryID = g.Key,
                                     Products = g.Select(item => new ProductModel(item.x, item.y))
                                 };
                }
            }
            return categories;
        }

        /// <summary>
        /// Get product list in category
        /// </summary>
        /// <param name="manufacturerID"> </param>
        /// <returns></returns>
        public static IEnumerable<Category> GetProductByManufacturer(int manufacturerID)
        {
            IEnumerable<Category> categories = null;
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var queryProducts = from x in context.Products.ToList()
                                        join y in context.ProductsDescription
                                        on x.ProductsID equals y.ProductsID
                                        select new { x, y };
                    categories = from item in queryProducts
                                 where (item.x.ManufacturersID & manufacturerID) == manufacturerID
                                 group item by item.x.MasterCategoriesID into g
                                 select new Category
                                 {
                                     CategoryID = g.Key,
                                     Products = g.Select(item => new ProductModel(item.x, item.y))
                                 };
                }
            }
            return categories;
        }

        /// <summary>
        /// Get product list in category by keyword
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Category> GetProductInCategory(string keyword)
        {
            keyword = keyword.ToLower();
            IEnumerable<Category> categories = null;
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var queryProducts = from x in context.Products.ToList()
                                        join y in context.ProductsDescription
                                        on x.ProductsID equals y.ProductsID
                                        select new { x, y };
                    categories = from item in queryProducts
                                 join cate in context.CategoriesDescription
                                 on item.x.MasterCategoriesID equals cate.CategoriesID
                                 where item.y.ProductsName.ToLower().Contains(keyword)
                                 || item.x.ProductsPrice.ToString().Contains(keyword)
                                 || (cate.CategoriesName.ToLower().Contains(keyword) && cate.LanguageID == 0)
                                 group item by item.x.MasterCategoriesID into g
                                 select new Category
                                 {
                                     CategoryID = g.Key,
                                     Products = g.Select(item => new ProductModel(item.x, item.y))
                                 };
                }
            }
            return categories;
        }

        /// <summary>
        /// Get product list
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ProductModel> GetProducts(int pageNumber, out int totalRecords)
        {
            IEnumerable<ProductModel> products = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    totalRecords = context.Products.Count();
                    products = from x in context.Products.OrderBy(x => x.ProductsID).Skip((pageNumber - 1) * Define.PageSize).Take(Define.PageSize).ToList()
                               join y in context.ProductsDescription
                               on x.ProductsID equals y.ProductsID
                               select new ProductModel(x, y);
                }
            }
            return products;
        }

        public static IEnumerable<ProductModel> GetProductsInTheSameCategory(int categoryID)
        {
            IEnumerable<ProductModel> products = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    // Load the product in the same category
                    products = from x in context.Products.ToList()
                               join y in context.ProductsDescription
                               on x.ProductsID equals y.ProductsID
                               where x.MasterCategoriesID == categoryID
                               select new ProductModel(x, y);
                }
            }

            return products;
        }

        public static ProductModel GetProductDetail(int productID)
        {
            ProductModel productModel = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {

                    Products product = context.Products.SingleOrDefault(x => x.ProductsID == productID);
                    ProductsDescription description = context.ProductsDescription.SingleOrDefault(x => x.ProductsID == productID);

                    if (null != product)
                    {
                        productModel = new ProductModel(product, description);
                    }
                }
            }

            return productModel;
        }

        public static bool DeleteItem(int id)
        {
            bool bflag = false;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var product = context.Products.SingleOrDefault(x => x.ProductsID == id);

                    if (null != product)
                    {
                        // Delete all descriptions
                        var descriptions = context.ProductsDescription.Where(x => x.ProductsID == id);
                        context.ProductsDescription.DeleteAllOnSubmit(descriptions);

                        // Delete product item
                        context.Products.DeleteOnSubmit(product);
                        context.SubmitChanges();

                        bflag = true;
                    }
                }
            }

            return bflag;
        }

        public static bool AddItem(ProductModel productModel)
        {
            try
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                {
                    using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        var product = new Products();
                        var description = new ProductsDescription();

                        productModel.UpdateData(product, description);

                        context.Products.InsertOnSubmit(product);
                        context.SubmitChanges();
                        description.ProductsID = product.ProductsID;
                        context.ProductsDescription.InsertOnSubmit(description);

                        context.SubmitChanges();
                    }
                }

                return true;
            }
            catch
            {
                throw;
            }
        }

        public static bool UpdateItem(ProductModel productModel)
        {
            try
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                {
                    using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        int productID = productModel.ProductID;
                        Products product = context.Products.SingleOrDefault(x => x.ProductsID == productID);
                        ProductsDescription description = context.ProductsDescription.SingleOrDefault(x => x.ProductsID == productID);

                        productModel.UpdateData(product, description);

                        context.SubmitChanges();
                    }
                }

                return true;
            }
            catch
            {
                throw;
            }
        }

    }
}