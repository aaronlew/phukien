using System;
using System.Linq;
using System.Collections.Generic;
using GiaPhuc.Utility;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using TNO.Education.Helpers;

namespace GiaPhuc
{
    public partial class Default : System.Web.UI.Page
    {
        private string Keyword { get { return (Request["keyword"] ?? string.Empty).ToLower(); } }
        private int CategoryId { get { return Convert.ToInt32(Request["CategoryID"]); } }
        private int ManufacturerId { get { return Convert.ToInt32(Request["ManufacturerID"]); } }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack || Keyword != string.Empty)
            {
                LoadProducts();
            }
        }

        private bool IsFirstVisit()
        {
            if (!SessionUtils.Exist("IsFirstVisit"))
            {
                SessionUtils.Set("IsFirstVisit", false);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            if (!base.IsPostBack)
            {
                // Block cookie less visit attempts
                if (IsFirstVisit())
                {
                    if (!ActionValidator.IsValid(ActionValidator.ActionTypeEnum.FirstVisit)) Response.End();
                }
                else
                {
                    if (!ActionValidator.IsValid(ActionValidator.ActionTypeEnum.Revisit)) Response.End();
                }
            }
            else
            {
                // Limit number of postbacks
                if (!ActionValidator.IsValid(ActionValidator.ActionTypeEnum.Postback)) Response.End();
            }
        }

        private void LoadProducts()
        {
            IList<CategoryInfo> categories;

            if (string.Empty != Keyword)
            {
                categories = CategoryImpl.GetAllProductInCategory(Keyword);
            }
            else if (0 != CategoryId)
            {
                categories = CategoryImpl.GetAllProductInCategory(CategoryId);
            }
            else
            {
                categories = SessionManager.AllCategories;
            }

            this.Repeater1.DataSource = categories;
            this.Repeater1.DataBind();
        }
    }
}