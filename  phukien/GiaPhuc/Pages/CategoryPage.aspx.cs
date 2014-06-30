using System;
using System.Collections.Generic;
using GiaPhuc.Utility;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Pages
{
    public partial class CategoryPage : ParentPage
    {
        #region Constant & Properties

        // Old ID
        private new string ID
        {
            get
            {
                object val = RouteValue("id");
                if (val == null) return null;
                return val.ToString();
            }
        }

        private string Url
        {
            get
            {
                object val = RouteValue("url");
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

                IList<CategoryInfo> categories = CategoryImpl.GetProducts(Url);
                SessionUtils.Set("AllCategories", false);
                Repeater1.DataSource = categories;
                Repeater1.DataBind();
            }
        }
    }
}