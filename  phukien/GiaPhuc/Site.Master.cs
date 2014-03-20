using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GiaPhuc.Data;
using GiaPhuc.Helper;
using phukienipadx.Core;
using GiaPhuc.Controls;

namespace GiaPhuc
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        private string Keyword { get { return Request["keyword"] ?? String.Empty; } }

        public IList<EZPages> Guides
        {
            get
            {
                if (Session["Guide"] == null)
                    Session["Guide"] = TopicHelper.GetTopics(PageType.Guide).ToList();
                return Session["Guide"] as IList<EZPages>;
            }
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

                if (Page is Default)
                {
                    LeftMenuControl leftMenuControl = LoadControl("~/Controls/LeftMenuControl.ascx") as LeftMenuControl;
                    this.pnlMenu.Controls.Add(leftMenuControl);
                }
                else
                {
                    LeftMenuControl leftMenuControl = LoadControl("~/Controls/LeftMenuControl.ascx") as LeftMenuControl;
                    this.pnlMenu1.Controls.Add(leftMenuControl);
                }
            }

        }
    }
}
