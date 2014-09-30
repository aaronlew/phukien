using System;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using phukienipadx.Core;
using phukienipadx.Core.Utilities;

namespace GiaPhuc.Admin.Pages
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
                ddlNewsCategory.DataSource = Define.PageTypes;
                ddlNewsCategory.DataBind();

                PageInfo post = PostImpl.GetPage(PageID);
                if (null != post)
                {
                    txtTitle.Text = post.Title;
                    ddlNewsCategory.SelectedIndex = post.CategoryId;
                    elm1.Value = post.HtmlContent.RemoveBadCode();
                }
            }
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            try
            {
                var title = elm1.Value.RemoveBadCode();
                PageInfo post = new PageInfo(PageID, title, StringUtils.GetGoodUrl(title))
                {
                    Title = txtTitle.Text,
                    HtmlContent = elm1.Value.RemoveBadCode(),
                    CategoryId = ddlNewsCategory.SelectedIndex
                };

                PostImpl.SavePost(post);

                if (PageID == 0)
                {
                    Response.Redirect("/Admin/Pages/PostEntry.aspx");
                }
                else
                {
                    Response.Redirect("/Admin/Pages/PostManager.aspx");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}