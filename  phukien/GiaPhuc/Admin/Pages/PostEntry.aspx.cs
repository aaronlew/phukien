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
using phukienipadx.Bl.Models;
using phukienipadx.Bl;

namespace GiaPhuc.Admin
{
    public partial class PostEntry : System.Web.UI.Page
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

                PageInfo post = PostImpl.GetTopic(PageID);
                if (null != post)
                {
                    this.txtTitle.Text = post.Title;
                    this.ddlNewsCategory.SelectedIndex = post.CategoryId;
                    this.elm1.Value = post.HtmlContent.RemoveBadCode();
                }
            }
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            try
            {
                PageInfo post = new PageInfo(PageID, this.elm1.Value.RemoveBadCode())
                {
                    Title = this.txtTitle.Text,
                    HtmlContent = this.elm1.Value.RemoveBadCode(),
                    CategoryId = this.ddlNewsCategory.SelectedIndex
                };

                PostImpl.SavePost(post);

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