namespace phukienipadx.Bl.Models
{
    public class PageInfo
    {
        public PageInfo()
        {
        }

        public PageInfo(int pageId, string htmlContent, string url)
        {
            PageId = pageId;
            HtmlContent = htmlContent;
            Url = url;
        }

        public int PageId { get; set; }
        public string Title { get; set; }
        public string Sapo { get; set; }
        public string HtmlContent { get; set; }
        public string Url { get; set; }
        public string Image_Roll { get; set; }
        public int CategoryId { get; set; }
    }
}