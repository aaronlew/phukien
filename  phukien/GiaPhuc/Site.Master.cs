using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GiaPhuc.Data;
using GiaPhuc.Helper;
using phukienipadx.Core;

namespace GiaPhuc
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        private string Keyword { get { return Request["keyword"] ?? String.Empty; } }

        public IList<EZPages> Guides
        {
            get { 
                if(Session["Guide"] == null)
                    Session["Guide"] = TopicHelper.GetTopics(PageType.Guide).ToList();
                return Session["Guide"] as IList<EZPages>; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Keyword != String.Empty)
                {
                    // this.txtSearchBox.Text = Keyword;
                }

                if (null == Session["InfoNews"])
                {
                    //Session["InfoNews"] = RssManager.ReadFeed(WebConfigurationManager.AppSettings["rss"]).Take(8).ToList();
                }

                this.SiteMapPath1.Visible = (!Equals(SiteMap.CurrentNode, SiteMap.RootNode));
                //this.HorizontalBanner1.Visible = !this.SiteMapPath1.Visible;
            }
        }
    }
}
