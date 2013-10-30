
namespace phukienipadx.Bl.Models
{
    public class PageInfo
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public string HtmlContent { get; set; }
        public int CategoryId { get; set; }

        public PageInfo(int pageId, string htmlContent)
        {
            this.PageId = pageId;
            this.HtmlContent = htmlContent;
        }
    }
}
