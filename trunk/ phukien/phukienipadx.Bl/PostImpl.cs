using System.Collections.Generic;
using System.Linq;
using phukienipadx.Bl.Models;
using phukienipadx.Dal.Repository;
using phukienipadx.Core;
using phukienipadx.Dal;

namespace phukienipadx.Bl
{
    public class PostImpl
    {
        public static IList<PageInfo> GetTopics()
        {
            var pageRep = new ezpagesRepository();

            var pages = pageRep.GetAllezpages();
            if (pages != null)
            {
                return pages.Select(x => new PageInfo(x.pages_id, x.pages_html_text, x.alt_url) { Title = x.pages_title }).ToList();
            }

            return new List<PageInfo>();
        }

        public static IList<PageInfo> GetTopics(int pageNumber, out int totalRecords)
        {
            var pageRep = new ezpagesRepository();

            var pages = pageRep.GetAllezpages();
            if (pages != null)
            {
                totalRecords = pages.Count();
                return pages.OrderBy(x => x.pages_id).Skip((pageNumber - 1) * Define.PageSize).Take(Define.PageSize).Select(x => new PageInfo(x.pages_id, x.pages_html_text, x.alt_url) { Title = x.pages_title }).ToList();
            }
            else
            {
                totalRecords = 0;
                return new List<PageInfo>();
            }
        }

        public static PageInfo GetTopic(int pageId)
        {
            var pageRep = new ezpagesRepository();

            var page = pageRep.GetSingleezpages(x => x.pages_id == pageId && x.languages_id == 0);
            if (page != null)
            {
                return new PageInfo(page.pages_id, page.pages_html_text, page.alt_url) { Title = page.pages_title, CategoryId = page.toc_chapter };
            }

            return null;
        }

        public static bool DeleteTopic(int id)
        {
            var pageRep = new ezpagesRepository();
            var post = pageRep.GetSingleezpages(x => x.pages_id == id);
            pageRep.Deleteezpages(post);
            return true;
        }


        public static bool SavePost(PageInfo post)
        {
            var pageRep = new ezpagesRepository();
            if (post.PageId == 0)
            {
                pageRep.Addezpages(new ezpages
                {
                    pages_title = post.Title,
                    pages_html_text = post.HtmlContent,
                    toc_chapter = post.CategoryId,
                    alt_url = post.Url
                });
            }
            else
            {
                var page = pageRep.GetSingleezpages(x => x.pages_id == post.PageId);
                if (page != null)
                {
                    page.pages_title = post.Title;
                    page.pages_html_text = post.HtmlContent;
                    page.toc_chapter = post.CategoryId;
                }
            }


            return true;
        }
    }
}
