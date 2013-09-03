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
    public partial class TopicPage : System.Web.UI.Page
    {
        private int PageID
        {
            get
            {
                if (null != Request["ID"])
                {
                    return int.Parse(Request["ID"]);
                }
                return 0;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TopicInfo topic = SessionManager.Topics.SingleOrDefault(x => x.TopicId == PageID);
                if (null != topic)
                {
                    divContent.InnerHtml = topic.HtmlContent.RemoveBadCode();
                    this.Title = String.Concat("Bao da iPad - phukienipadx.com - ", topic.Title);
                }
            }
        }
    }
}