using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using GiaPhuc.Data;
using GiaPhuc.Helper;
using GiaPhuc.Utility;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Pages
{
    public partial class TopicPage : ParentPage
    {
        // Old ID
        public string ID
        {
            get
            {
                var val = RouteValue("id");
                if (val == null) return null;
                return val.ToString();
            }
        }

        public string Url
        {
            get
            {
                var val = RouteValue("url");
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
                    var post = SessionManager.Topics.SingleOrDefault(x => x.PageId == int.Parse(ID));
                    Response.Status = "301 Moved Permanently";
                    Response.AddHeader("Location", "/bai-viet/" + post.Url);
                    Response.End();
                }

                var url = Url;
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
                PageInfo topic = SessionManager.Topics.SingleOrDefault(x => x.Url == url);
                if (null != topic)
                {
                    divContent.InnerHtml = topic.HtmlContent.RemoveBadCode();
                    this.Title = String.Concat("Bao da iPad - phukienipadx.com - ", topic.Title);
                }
            }
        }
    }
}