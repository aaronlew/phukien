
namespace phukienipadx.Bl.Models
{
    public class PageInfo
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public string HtmlContent { get; set; }
        public string Url { get; set; }
        public int CategoryId { get; set; }

        public PageInfo()
        {

        }

        public PageInfo(int pageId, string htmlContent, string url)
        {
            this.PageId = pageId;
            this.HtmlContent = htmlContent;
            this.Url = url;
        }
    }
}
