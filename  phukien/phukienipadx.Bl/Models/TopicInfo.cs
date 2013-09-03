
namespace phukienipadx.Bl.Models
{
    public class TopicInfo
    {
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string HtmlContent { get; set; }

        public TopicInfo(int topicId, string htmlContent)
        {
            this.TopicId = topicId;
            this.HtmlContent = htmlContent;
        }
    }
}
