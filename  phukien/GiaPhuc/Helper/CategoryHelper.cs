using GiaPhuc.App_Data;
using GiaPhuc.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GiaPhuc.Helper
{
    public class CategoryHelper : DataHelper
    {
        /// <summary>
        /// Get a category
        /// </summary>
        /// <returns></returns>
        public static CategoryBrief GetCategory()
        {
            return GetCategory(0);
        }

        /// <summary>
        /// Get a category
        /// </summary>
        /// <returns></returns>
        public static CategoryBrief GetCategory(int categoryId)
        {
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var category = from x in context.Categories
                                   join y in context.CategoriesDescription
                                   on x.CategoriesID equals y.CategoriesID
                                   where x.CategoriesID == categoryId
                                   && y.LanguageID == 0
                                   select new CategoryBrief(x, y);
                    return category.SingleOrDefault();
                }
            }
        }

        public static IList<CategoryBrief> GetCategories()
        {
            IEnumerable<CategoryBrief> categories = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    categories = from x in context.Categories.ToList()
                                 join y in context.CategoriesDescription
                                 on x.CategoriesID equals y.CategoriesID
                                 orderby x.SortOrder
                                 select new CategoryBrief
                                 {
                                     CategoryID = x.CategoriesID,
                                     CategoryName = y.CategoriesName,
                                     Deactive = !Convert.ToBoolean(x.CategoriesStatus),
                                     SubCategories = (from sub in context.Manufacturers
                                                     select new CategoryBrief
                                                                {
                                                                    CategoryID = sub.ManufacturersID,
                                                                    CategoryName = sub.ManufacturersName
                                                                }).ToList()
                                 };
                }
            }

            return categories.ToList();
        }

        public static bool SaveCategory(CategoryBrief categoryBrief)
        {
            try
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                {
                    using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        if (categoryBrief.CategoryID == 0)
                        {
                            var category = new Categories
                            {
                                CategoriesID = categoryBrief.CategoryID,
                                CategoriesStatus = Convert.ToSByte(!categoryBrief.Deactive)
                            };
                            context.Categories.InsertOnSubmit(category);
                            context.SubmitChanges();

                            var description = new CategoriesDescription
                            {
                                CategoriesID = category.CategoriesID,
                                CategoriesName = categoryBrief.CategoryName,
                                LanguageID = 0
                            };

                            context.CategoriesDescription.InsertOnSubmit(description);

                            context.SubmitChanges();
                        }
                        else
                        {
                            var category = context.CategoriesDescription.SingleOrDefault(x => x.CategoriesID == categoryBrief.CategoryID && x.LanguageID == 0);
                            if (category != null) category.CategoriesName = categoryBrief.CategoryName;

                            context.SubmitChanges();
                        }

                    }
                }
            }
            catch
            {
                throw;
            }

            return true;
        }

        public static bool DeleteCategory(int id)
        {
            bool bflag = false;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var category = context.Categories.SingleOrDefault(x => x.CategoriesID == id);

                    if (null != category)
                    {
                        context.Categories.DeleteOnSubmit(category);
                        context.SubmitChanges();

                        bflag = true;
                    }
                }
            }

            return bflag;
        }
    }
}