using System;
using System.Linq;
using GiaPhuc.Utility;
using phukienipadx.Bl.Models;
using phukienipadx.Core.Utilities;

namespace GiaPhuc.Pages
{
    public partial class TopicPage : ParentPage
    {
        // Old ID
        public new string ID
        {
            get
            {
                object val = RouteValue("id");
                if (val == null) return null;
                return val.ToString();
            }
        }

        public string Url
        {
            get
            {
                object val = RouteValue("url");
                if (val == null) return null;
                return val.ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ID != null)
                {
                    PageInfo post = SessionManager.Topics.SingleOrDefault(x => x.PageId == int.Parse(ID));
                    Response.Status = "301 Moved Permanently";
                    if (post != null) Response.AddHeader("Location", "/bai-viet/" + post.Url);
                    Response.End();
                }

                string url = Url;
                if (Request.Url.AbsolutePath.EndsWith("mua-hang"))
                {
                    url = "huong-dan-mua-hang";
                }
                else if (Request.Url.AbsolutePath.EndsWith("su-dung"))
                {
                    url = "huong-dan-su-dung";
                }
                else if (Request.Url.AbsolutePath.EndsWith("bao-hanh"))
                {
                    url = "quy-dinh-bao-hanh";
                }
                else if (Request.Url.AbsolutePath.EndsWith("doi-tac"))
                {
                    url = "tim-doi-tac";
                }
                else if (Request.Url.AbsolutePath.EndsWith("bao-mat"))
                {
                    url = "chinh-sach-bao-mat";
                }
                PageInfo topic = SessionManager.Topics.SingleOrDefault(x => x.Url == url);
                if (null != topic)
                {
                    divContent.InnerHtml = topic.HtmlContent.RemoveBadCode();
                    Title = string.Concat(topic.Title, " - phukienipadx.com");
                }
            }
        }
    }
}