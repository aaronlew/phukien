using System;
using System.Web.UI;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using phukienipadx.Core.Utilities;

namespace GiaPhuc.Admin.Pages
{
    public partial class CategoryEntry : Page
    {
        private int Id
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
                CategoryInfo category = CategoryImpl.GetCategory(Id);
                if (null != category)
                {
                    txtCategoryName.Text = category.Name;
                }
            }
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            var category = new CategoryInfo(Id, Id, txtCategoryName.Text,
                StringUtils.GetGoodUrl(txtCategoryName.Text));
            //Deactive = this.chkDeactive.Checked

            CategoryImpl.Save(category);

            if (Id == 0)
            {
                Response.Redirect("/Admin/Pages/CategoryEntry.aspx");
            }
            else
            {
                Response.Redirect("/Admin/Pages/CategoryManager.aspx");
            }
        }
    }
}