using System;
using System.Collections.Generic;
using System.Linq;
using phukienipadx.Bl.Models;
using phukienipadx.Dal;
using phukienipadx.Dal.Repository;

namespace phukienipadx.Bl
{
    public class CategoryImpl
    {
        /// <summary>
        ///     Get the hierarchy categories
        /// </summary>
        /// <returns></returns>
        public static IList<CategoryInfo> GetHierarchyCategories()
        {
            using (var db = new phukienipadxContext())
            {
                IQueryable<CategoryInfo> query = from x in db.categories
                                                 join y in db.categories_descriptions
                                                     on x.categories_id equals y.categories_id
                                                 where x.categories_id > 0
                                                 orderby x.sort_order
                                                 select new CategoryInfo(x.parent_id, x.categories_id, y.categories_name, y.categories_url);

                // ReSharper disable once SuspiciousTypeConversion.Global
                List<CategoryInfo> allCategories = query as List<CategoryInfo> ?? query.ToList();
                IEnumerable<CategoryInfo> mainCategories = allCategories.Where(x => x.ParentId == 0);
                List<CategoryInfo> categoryModels = mainCategories as List<CategoryInfo> ?? mainCategories.ToList();
                foreach (CategoryInfo node in categoryModels)
                {
                    FillHierarchyCategories(node, allCategories);
                }

                return categoryModels.ToList();
            }
        }

        /// <summary>
        ///     Fill the hierarchy categories
        /// </summary>
        /// <param name="node"></param>
        /// <param name="allCategories"></param>
        private static void FillHierarchyCategories(CategoryInfo node, IEnumerable<CategoryInfo> allCategories)
        {
            List<CategoryInfo> categories = allCategories as List<CategoryInfo> ?? allCategories.ToList();
            bool hasItems = categories.Any(x => x.ParentId == node.CategoryId);
            if (hasItems) node.Categories = new List<CategoryInfo>();
            IEnumerable<CategoryInfo> categoryInfos = categories.Where(x => x.ParentId == node.CategoryId);
            List<CategoryInfo> closestNodes = categoryInfos as List<CategoryInfo> ?? categoryInfos.ToList();
            foreach (CategoryInfo closestNode in closestNodes)
            {
                node.Categories.Add(closestNode);
                FillHierarchyCategories(closestNode, closestNodes);
            }
        }

        /// <summary>
        ///     Get all product in category
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

            if (categoryId == 0)
            {
                return (from item in queryProducts
                        join y in categoryRep.GetAllcategories()
                            on item.x.master_categories_id equals y.categories_id
                        join z in categoryDescriptionRep.GetAllcategories_descriptions()
                            on item.x.master_categories_id equals z.categories_id
                        where y.home_order != null
                        orderby y.home_order, item.x.products_price descending, item.x.products_model, item.y.products_name
                        group item by z
                            into g
                            select new CategoryInfo(0, g.Key.categories_id, g.Key.categories_name, g.Key.categories_url)
                            {
                                Products = g.Select(item => new ProductInfo(item.x, item.y)).ToList()
                            }).ToList();
            }
            categories_descriptions categoryDescription =
                categoryDescriptionRep.GetSinglecategories_descriptions(x => x.categories_id == categoryId
                                                                             && x.language_id == 0);

            // Get product list by the category Id
            return new List<CategoryInfo>
            {
                new CategoryInfo(0, categoryId, categoryDescription.categories_name, categoryDescription.categories_url)
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
        ///     Get all product in category
        /// </summary>
        /// <returns></returns>
        public static IList<CategoryInfo> GetProducts(string categoriesUrl)
        {
            using (var db = new phukienipadxContext())
            {
                var queryProducts = from x in db.products
                                    join y in db.products_descriptions
                                        on x.products_id equals y.products_id
                                    where x.products_status == 1
                                    select new { x, y };

                if (categoriesUrl == string.Empty)
                {
                    return null;
                }

                categories_description categoryDescription =
                    db.categories_descriptions.FirstOrDefault(x => x.categories_url == categoriesUrl
                                                                   && x.language_id == 0);

                // Get product list by the category Id
                if (categoryDescription != null)
                    return new List<CategoryInfo>
                    {
                        new CategoryInfo(0, categoryDescription.categories_id, categoryDescription.categories_description1,
                            categoryDescription.categories_url)
                        {
                            Products = (from item in queryProducts
                                join z in db.products_to_categories
                                    on item.x.products_id equals z.products_id
                                where z.categories_id == categoryDescription.categories_id
                                orderby item.x.products_price descending, item.x.products_model, item.y.products_name
                                select new {a = item.x, b = item.y}).ToList()
                                .Select(x => new ProductInfo(x.a, x.b))
                                .ToList()
                        }
                    };
                return null;
            }
        }

        /// <summary>
        ///     Get all product in category by keyword
        /// </summary>
        /// <returns></returns>
        public static IList<CategoryInfo> GetAllProductInCategory(string keyword)
        {
            using (var db = new phukienipadxContext())
            {
                var queryProducts = from x in db.products
                                    join y in db.products_descriptions
                                        on x.products_id equals y.products_id
                                    where x.products_status == 1
                                    orderby x.products_price descending, x.products_model, y.products_name
                                    select new { x, y };


                // by cate
                string keyword1 = keyword;
                var list = (from item in queryProducts
                            join z in db.categories_descriptions
                                on item.x.master_categories_id equals z.categories_id
                            where (item.y.products_name.ToLower().Contains(keyword1)
                                  || z.categories_name.ToLower().Contains(keyword1))
                                  && z.language_id == 0
                            group item by z
                                into g
                                select new CategoryInfo(0, g.Key.categories_id, g.Key.categories_name, g.Key.categories_url)
                                {
                                    Products = g.Select(item => new ProductInfo(item.x, item.y)).ToList()
                                }).ToList();
                if (list.Count == 0 && keyword.Contains(" "))
                {
                    while (keyword.Contains("  "))
                        keyword = keyword.Replace("  ", " ");
                    string[] keywords = keyword.Split(' ');
                    for (int i = 0; i < keywords.Length; i++)
                    {
                        for (int j = i + 1; j < keywords.Length; j++)
                        {
                            string phrase = keywords[i] + ' ' + keywords[j];
                            list.InsertRange(0, from item in queryProducts
                                                join z in db.categories_descriptions
                                                    on item.x.master_categories_id equals z.categories_id
                                                where (item.y.products_name.ToLower().Contains(phrase)
                                                      || z.categories_name.ToLower().Contains(phrase))
                                                      && z.language_id == 0
                                                group item by z
                                                    into g
                                                    select new CategoryInfo(0, g.Key.categories_id, g.Key.categories_name, g.Key.categories_url)
                                                    {
                                                        Products = g.Select(item => new ProductInfo(item.x, item.y)).ToList()
                                                    });
                        }
                    }
                }
                return list;
            }
        }

        /// <summary>
        ///     Get All Categories for Edit
        /// </summary>
        /// <returns></returns>
        public static IList<CategoryInfo> GetCategories()
        {
            using (var db = new phukienipadxContext())
            {
                IEnumerable<CategoryInfo> categories = from x in db.categories
                                                       join y in db.categories_descriptions
                                                           on x.categories_id equals y.categories_id
                                                       where y.language_id == 0
                                                       orderby (x.parent_id == 0 ? x.categories_id : x.parent_id), x.sort_order
                                                       select
                                                           new CategoryInfo(x.parent_id, x.categories_id, y.categories_name, y.categories_url)
                                                           {
                                                               Active = Convert.ToBoolean(x.categories_status)
                                                           };

                return categories.ToList();
            }
        }


        /// <summary>
        ///     Get a category
        /// </summary>
        /// <returns></returns>
        public static CategoryInfo GetCategory(int id)
        {
            using (var db = new phukienipadxContext())
            {
                IEnumerable<CategoryInfo> categories = from x in db.categories
                                                       join y in db.categories_descriptions
                                                           on x.categories_id equals y.categories_id
                                                       where y.language_id == 0 && x.categories_id == id
                                                       select
                                                           new CategoryInfo(x.parent_id, x.categories_id, y.categories_name, y.categories_url)
                                                           {
                                                               Active = Convert.ToBoolean(x.categories_status)
                                                           };
                return categories.SingleOrDefault();
            }
        }

        public static bool Save(CategoryInfo categoryInfo)
        {
            var categoryRep = new categoriesRepository();
            var categoryDescriptionRep = new categories_descriptionsRepository();

            if (categoryInfo.CategoryId == 0)
            {
                var cate = new categories
                {
                    categories_status = Convert.ToSByte(categoryInfo.Active)
                };
                categoryRep.Addcategories(cate);
                categoryRep.Commit();

                var description = new categories_descriptions
                {
                    categories_id = cate.categories_id,
                    categories_name = categoryInfo.Name,
                    language_id = 0
                };

                categoryDescriptionRep.Addcategories_descriptions(description);
                categoryDescriptionRep.Commit();
            }
            else
            {
                categories_descriptions category =
                    categoryDescriptionRep.GetSinglecategories_descriptions(
                        x => x.categories_id == categoryInfo.CategoryId && x.language_id == 0);
                if (category != null) category.categories_name = categoryInfo.Name;

                categoryDescriptionRep.Commit();
            }

            return true;
        }
    }
}