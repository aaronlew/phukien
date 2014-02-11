using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using phukienipadx.Bl;
using GiaPhuc.Utility;

namespace GiaPhuc.Pages
{
    public partial class CategoryPage : ParentPage
    {
        #region Constant & Properties
        const int PageSize = 10;

        // Old ID
        private string ID
        {
            get
            {
                var val = RouteValue("id");
                if(val == null) return null;
                return val.ToString();
            }
        }

        private string Url
        {
            get
            {
                var val = RouteValue("url");
                if (val == null) return null;
                return val.ToString();
            }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ID != null)
                {
                    Response.Status = "301 Moved Permanently";
                    Response.AddHeader("Location", CategoryImpl.GetCategory(int.Parse(ID)).Url);
                    Response.End();
                }

                var categories = CategoryImpl.GetProducts(Url);
                SessionUtils.Set("AllCategories", false);
                this.Repeater1.DataSource = categories;
                this.Repeater1.DataBind();
            }
        }
    }
}