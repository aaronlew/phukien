using System.Collections.Generic;
using System.Linq;
using phukienipadx.Bl.Models;
using phukienipadx.Dal.Repository;

namespace phukienipadx.Bl
{
    public class TopicImpl
    {
        public static IList<TopicInfo> GetTopics()
        {
            var pageRep = new ezpagesRepository();

            var pages = pageRep.GetAllezpages();
            if (pages != null)
            {
                return pages.Select(x => new TopicInfo(x.pages_id, x.pages_html_text) { Title = x.pages_title}).ToList();
            }

            return new List<TopicInfo>();
        }

        public static TopicInfo GetTopic(int pageId)
        {
            var pageRep = new ezpagesRepository();

            var page = pageRep.GetSingleezpages(x => x.pages_id == pageId && x.languages_id == 0);
            if (page != null)
            {
                return new TopicInfo(page.pages_id, page.pages_html_text) { Title = page.pages_title };
            }

            return null;
        }
    }
}
