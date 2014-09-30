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
        public static IList<PageInfo> GetPages(int cateId)
        {
            var pageRep = new ezpagesRepository();

            var pages = pageRep.Queryezpages(x => x.toc_chapter == cateId && x.toc_sort_order > 0).OrderBy(x => x.toc_sort_order).Take(12);
            return pages.Select(x => new PageInfo { PageId = x.pages_id, Url = x.alt_url, Title = x.pages_title, Image_Roll = x.alt_url_external }).ToList();
        }

        public static IList<PageInfo> GetPages()
        {
            var pageRep = new ezpagesRepository();

            var pages = pageRep.GetAllezpages();
            if (pages != null)
            {
                return pages.Select(x => new PageInfo(x.pages_id, x.pages_html_text, x.alt_url) { Title = x.pages_title }).ToList();
            }

            return new List<PageInfo>();
        }

        public static IList<PageInfo> PagingPages(int pageNumber, out int totalRecords)
        {
            using (var db = new phukienipadxContext())
            {
                IQueryable<ezpage> query = (from x in db.ezpages select x);

                totalRecords = query.Count();
                if (totalRecords > 0)
                {
                    return query.OrderBy(x => x.pages_id).Skip((pageNumber - 1) * Define.PageSize).Take(Define.PageSize).Select(x => new PageInfo { PageId = x.pages_id, Url = x.alt_url, Title = x.pages_title }).ToList();
                }
                return new List<PageInfo>();
            }
        }

        public static PageInfo GetPage(int pageId)
        {
            using (var db = new phukienipadxContext())
            {
                var page = db.ezpages.SingleOrDefault(x => x.pages_id == pageId && x.languages_id == 0);
                if (page != null)
                {
                    return new PageInfo(page.pages_id, page.pages_html_text, page.alt_url) { Title = page.pages_title, CategoryId = page.toc_chapter };
                }
            }
            return null;
        }

        public static bool DeleteTopic(int id)
        {
            var pageRep = new ezpagesRepository();
            var post = pageRep.GetSingleezpages(x => x.pages_id == id);
            pageRep.Deleteezpages(post);
            pageRep.Commit();
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
                    alt_url = post.Url,
                    alt_url_external = post.Url
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
            pageRep.Commit();


            return true;
        }
    }
}
