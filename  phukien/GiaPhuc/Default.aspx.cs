using System;
using System.Collections.Generic;
using GiaPhuc.Pages;
using GiaPhuc.Utility;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using TNO.Education.Helpers;

namespace GiaPhuc
{
    public partial class Default : ParentPage
    {
        //private string Keyword { get { return (Request["keyword"] ?? string.Empty).ToLower(); } }

        private string Keyword
        {
            get
            {
                return (RouteValue("keyword") ?? string.Empty).ToString().ToLower();
            }
        }

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
            else
            {
                categories = SessionManager.AllCategories;
                SessionUtils.Set("AllCategories", true);
            }

            this.Repeater1.DataSource = categories;
            this.Repeater1.DataBind();
        }
    }
}