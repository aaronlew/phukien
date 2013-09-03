using GiaPhuc.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace GiaPhuc.Helper
{
    public class MetaTagHelper : DataHelper
    {

        public static MetaTags GetMetaTag()
        {
            MetaTags metaTag = null;

            try
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                {
                    using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        metaTag = (from x in context.MetaTags
                                   where x.LanguageID == 0
                                   select x).FirstOrDefault();
                    }
                }

                return metaTag;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

        public static bool SaveMetaTag(string title, string metaKeywords, string metaDescription)
        {
            bool flag = false;

            try
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                {
                    using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        var metaTag = (from x in context.MetaTags
                                       where x.LanguageID == 0
                                       select x).FirstOrDefault();

                        if (null == metaTag)
                        {
                            metaTag = new MetaTags
                            {
                                MetaTagsTitle = title,
                                MetaTagsKeywords = metaKeywords,
                                MetaTagsDescription = metaDescription
                            };

                            context.MetaTags.InsertOnSubmit(metaTag);
                        }
                        else
                        {
                            metaTag.MetaTagsTitle = title;
                            metaTag.MetaTagsKeywords = metaKeywords;
                            metaTag.MetaTagsDescription = metaDescription;
                        }

                        context.SubmitChanges();
                    }
                }

                flag = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }

            return flag;
        }

    }
}