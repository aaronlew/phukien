using GiaPhuc.App_Data;
using GiaPhuc.Data;
using GiaPhuc.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Admin.Pages
{
    public partial class CategoryEntry : System.Web.UI.Page
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
                    this.txtCategoryName.Text = category.Name;
                }
            }
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryInfo category = new CategoryInfo(Id, Id, this.txtCategoryName.Text);
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
            catch
            {
                throw;
            }
        }
    }
}