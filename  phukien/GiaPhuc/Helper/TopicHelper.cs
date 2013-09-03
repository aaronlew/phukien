using GiaPhuc.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using GiaPhuc.Utility;
using phukienipadx.Core;

namespace GiaPhuc.Helper
{
    public class TopicHelper : DataHelper
    {
        /// <summary>
        /// Get the topic list
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="totalRecords"></param>
        /// <returns></returns>
        public static IList<EZPages> GetTopics(int pageNumber, out int totalRecords)
        {
            IEnumerable<EZPages> topics = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    totalRecords = context.EZPages.Count();
                    topics = context.EZPages.OrderBy(x => x.PagesID).Skip((pageNumber - 1) * Define.PageSize).Take(Define.PageSize).ToList().Select(
                        x => new EZPages
                        {
                            PagesID = x.PagesID,
                            PagesTitle = x.PagesTitle,
                            ToCChapter = x.ToCChapter
                        });
                }
            }

            return topics.ToList();
        }

        /// <summary>
        /// Get the topic content
        /// </summary>
        /// <returns></returns>
        public static EZPages GetTopic(int topicID)
        {
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var page = context.EZPages.SingleOrDefault(x => x.PagesID == topicID);
                    return page;
                }
            }
        }

        public static IList<EZPages> GetTopics(PageType pageType)
        {
            IEnumerable<EZPages> topics = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    topics = context.EZPages.Where(x => x.ToCChapter == (int)pageType).OrderBy(x => x.PagesTitle);
                }
            }

            return topics.ToList();
        }

        public static bool DeleteTopic(int id)
        {
            bool bflag = false;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var page = context.EZPages.SingleOrDefault(x => x.PagesID == id);

                    if (null != page)
                    {
                        context.EZPages.DeleteOnSubmit(page);
                        context.SubmitChanges();

                        bflag = true;
                    }
                }
            }

            return bflag;
        }
        
        public static bool SaveTopic(EZPages page)
        {
            bool flag = false;

            try
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                {
                    using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        if (page.PagesID == 0)
                        {
                            context.EZPages.InsertOnSubmit(page);
                        }
                        else
                        {
                            EZPages ezpage = context.EZPages.SingleOrDefault(x => x.PagesID == page.PagesID);

                            ezpage.PagesTitle = page.PagesTitle;
                            ezpage.PagesHTMLText = page.PagesHTMLText;
                            ezpage.ToCChapter = page.ToCChapter;
                        }

                        context.SubmitChanges();
                    }
                }

                flag = true;
            }
            catch
            {
                throw;
            }

            return flag;
        }
    }
}