using GiaPhuc.App_Data;
using GiaPhuc.Data;
using GiaPhuc.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GiaPhuc.Admin.Pages
{
    public partial class CategoryEntry : System.Web.UI.Page
    {
        private int CategoryID
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
                CategoryBrief category = CategoryHelper.GetCategory(CategoryID);
                if (null != category)
                {
                    this.txtCategoryName.Text = category.CategoryName;
                }
            }
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryBrief category = new CategoryBrief
                {
                    CategoryID = CategoryID,
                    CategoryName = this.txtCategoryName.Text,
                    Deactive = this.chkDeactive.Checked
                };

                CategoryHelper.SaveCategory(category);

                if (CategoryID == 0)
                {
                    Response.Redirect("/Admin/Pages/CategoryEntry.aspx");
                }
                else
                {
                    Response.Redirect("/Admin/Pages/CategoryManager.aspx");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}