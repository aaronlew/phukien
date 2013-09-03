using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GiaPhuc.Admin
{
    public partial class AdminSite : System.Web.UI.MasterPage
    {
        const string loginPage = "/Admin/Login.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.siteMapPath1.Visible = (SiteMap.CurrentNode != SiteMap.RootNode);

                using (System.Web.UI.HtmlControls.HtmlMeta meta = new System.Web.UI.HtmlControls.HtmlMeta())
                {
                    meta.Name = "description";
                    meta.Content = "Portal Administration.";
                    this.Page.Header.Controls.Add(meta);
                }

                using (System.Web.UI.HtmlControls.HtmlMeta meta = new System.Web.UI.HtmlControls.HtmlMeta())
                {
                    meta.Name = "keyword";
                    meta.Content = "Portal Administration.";
                    this.Page.Header.Controls.Add(meta);
                }

                //if (!HttpContext.Current.User.Identity.IsAuthenticated && !HttpContext.Current.Request.Url.LocalPath.Equals(loginPage))
                //{
                //    Response.Redirect(loginPage);
                //}
            }
        }
    }
}