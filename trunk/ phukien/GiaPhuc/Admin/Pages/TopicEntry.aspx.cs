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
using phukienipadx.Core;

namespace GiaPhuc.Admin
{
    public partial class TopicEntry : System.Web.UI.Page
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
                this.ddlNewsCategory.DataSource = Define.PageTypes;
                this.ddlNewsCategory.DataBind();

                EZPages page = TopicHelper.GetTopic(PageID);
                if (null != page)
                {
                    this.txtTitle.Text = page.PagesTitle;
                    this.ddlNewsCategory.SelectedIndex = page.ToCChapter;
                    this.elm1.Value = page.PagesHTMLText.RemoveBadCode();
                }
            }
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            try
            {
                EZPages ezpage = new EZPages
                {
                    PagesID = PageID,
                    ALtURL = String.Empty,
                    ALtURLExternal = String.Empty,
                    PagesTitle = this.txtTitle.Text,
                    PagesHTMLText = this.elm1.Value.RemoveBadCode(),
                    ToCChapter = this.ddlNewsCategory.SelectedIndex
                };

                TopicHelper.SaveTopic(ezpage);

                if (PageID == 0)
                {
                    Response.Redirect("/Admin/Pages/TopicEntry.aspx");
                }
                else
                {
                    Response.Redirect("/Admin/Pages/TopicManager.aspx");
                }
            }
            catch
            {
                throw;
            }
        }

    }
}