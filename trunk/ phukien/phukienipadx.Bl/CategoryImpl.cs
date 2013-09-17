using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using phukienipadx.Bl.Models;
using phukienipadx.Core;
using phukienipadx.Dal.Repository;

namespace phukienipadx.Bl
{
    public class CategoryImpl
    {
        /// <summary>
        /// Get the hierarchy categories 
        /// </summary>
        /// <returns></returns>
        public static IList<CategoryInfo> GetHierarchyCategories()
        {
            var rep = new categoriesRepository();
            var repCategoryDescription = new categories_descriptionsRepository();
            var query = from x in rep.GetAllcategories()
                        join y in repCategoryDescription.GetAllcategories_descriptions()
                            on x.categories_id equals y.categories_id
                        orderby x.sort_order
                        select new CategoryInfo(x.parent_id, x.categories_id, y.categories_name);

            var allCategories = query as List<CategoryInfo> ?? query.ToList();
            IEnumerable<CategoryInfo> mainCategories = allCategories.Where(x => x.ParentId == 0);
            var categoryModels = mainCategories as List<CategoryInfo> ?? mainCategories.ToList();
            foreach (CategoryInfo node in categoryModels)
            {
                FillHierarchyCategories(node, allCategories);
            }

            return categoryModels.ToList();
        }

        /// <summary>
        /// Fill the hierarchy categories
        /// </summary>
        /// <param name="node"></param>
        /// <param name="allCategories"></param>
        private static void FillHierarchyCategories(CategoryInfo node, IEnumerable<CategoryInfo> allCategories)
        {
            var categories = allCategories as List<CategoryInfo> ?? allCategories.ToList();
            var hasItems = categories.Any(x => x.ParentId == node.CategoryId);
            if (hasItems) node.Categories = new List<CategoryInfo>();
            var categoryInfos = categories.Where(x => x.ParentId == node.CategoryId);
            var closestNodes = categoryInfos as List<CategoryInfo> ?? categoryInfos.ToList();
            foreach (CategoryInfo closestNode in closestNodes)
            {
                node.Categories.Add(closestNode);
                FillHierarchyCategories(closestNode, closestNodes);
            }
        }

        /// <summary>
        /// Get all product in category
        /// </summary>
        /// <returns></returns>
        public static IList<CategoryInfo> GetAllProductInCategory(int categoryId = 0)
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();
            var productToCategoryRep = new products_to_categoriesRepository();
            var categoryRep = new categoriesRepository();
            var categoryDescriptionRep = new categories_descriptionsRepository();

            var queryProducts = from x in productRep.Findproducts(x => x.products_status == 1)
                                join y in productDescriptionRep.GetAllproducts_descriptions()
                                on x.products_id equals y.products_id
                                select new { x, y };

            //DirectoryInfo dir = new DirectoryInfo(@"F:\Workspace\phukienipadx solution\GiaPhuc\Upload\Thumbs\");
            //FileInfo[] files = dir.GetFiles();

            //foreach (var file in files)
            //{
            //    bool result = queryProducts.Any(x => file.FullName.EndsWith(x.x.products_image, StringComparison.OrdinalIgnoreCase));
            //    if (result)
            //    {
            //        continue;
            //    }

            //    file.Delete();
            //}

            if (categoryId == 0)
            {
                return (from item in queryProducts
                        join y in categoryRep.GetAllcategories()
                            on item.x.master_categories_id equals y.categories_id
                        join z in categoryDescriptionRep.GetAllcategories_descriptions()
                            on item.x.master_categories_id equals z.categories_id
                        orderby y.sort_order, item.x.products_price descending, item.x.products_model, item.y.products_name 
                        group item by z
                            into g
                            select new CategoryInfo(0, g.Key.categories_id, g.Key.categories_name)
                            {
                                Products = g.Select(item => new ProductInfo(item.x, item.y)).ToList()
                            }).ToList();
            }
            var categoryDescription =
                categoryDescriptionRep.GetSinglecategories_descriptions(x => x.categories_id == categoryId
                                                                             && x.language_id == 0);

            // Get product list by the category Id
            return new List<CategoryInfo>
                       {
                           new CategoryInfo(0, categoryId, categoryDescription.categories_name)
                               {
                                   Products = (from item in queryProducts
                                               join z in
                                                   productToCategoryRep.Findproducts_to_categories(
                                                       x => x.categories_id == categoryId)
                                                   on item.x.products_id equals z.products_id
                                               orderby item.x.products_price descending, item.x.products_model, item.y.products_name 
                                               select new ProductInfo(item.x, item.y)).ToList()
                               }
                       };
        }

        /// <summary>
        /// Get all product in category by keyword
        /// </summary>
        /// <returns></returns>
        public static IList<CategoryInfo> GetAllProductInCategory(string keyword)
        {
            var productRep = new productsRepository();
            var productDescriptionRep = new products_descriptionsRepository();
            var categoryDescriptionRep = new categories_descriptionsRepository();

            var queryProducts = from x in productRep.Findproducts(x => x.products_status == 1)
                                join y in productDescriptionRep.GetAllproducts_descriptions()
                                on x.products_id equals y.products_id
                                orderby x.products_price descending, x.products_model, y.products_name
                                select new { x, y };


            // Get product list by the category Id
            return (from item in queryProducts
                    join z in categoryDescriptionRep.GetAllcategories_descriptions()
                        on item.x.master_categories_id equals z.categories_id
                    where item.y.products_name.ToLower().Contains(keyword)
                    || item.x.products_price.ToString(CultureInfo.InvariantCulture).Contains(keyword)
                    || (z.categories_name.ToLower().Contains(keyword) && z.language_id == 0)
                    group item by z
                        into g
                        select new CategoryInfo(0, g.Key.categories_id, g.Key.categories_name)
                        {
                            Products = g.Select(item => new ProductInfo(item.x, item.y)).ToList()
                        }).ToList();

        }

        /// <summary>
        /// Get All Categories for Edit
        /// </summary>
        /// <returns></returns>
        public static IList<CategoryInfo> GetCategories()
        {
            var categoryRep = new categoriesRepository();
            var categoryDescriptionRep = new categories_descriptionsRepository();

            IEnumerable<CategoryInfo> categories = from x in categoryRep.GetAllcategories()
                                                   join y in categoryDescriptionRep.GetAllcategories_descriptions()
                                                       on x.categories_id equals y.categories_id
                                                   where y.language_id == 0
                                                   orderby (x.parent_id == 0 ? x.categories_id : x.parent_id), x.sort_order
                                                   select new CategoryInfo(x.parent_id, x.categories_id, y.categories_name) { Active = Convert.ToBoolean(x.categories_status) };

            return categories.ToList();
        }
    }
}
