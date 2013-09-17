﻿using System;
using System.Web.UI;
using GiaPhuc.Utility;

namespace GiaPhuc.Controls
{
    public partial class UCProductCategory : System.Web.UI.UserControl
    {
        const string GroupSection = "<ul class=\"section group\">{0}</ul>";

        #region Properties

        public string CategoryUrl { get; set; }
        public string CategoryName { get; set; }
        public object DataSource { get; set; }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (DataSource != null)
                {
                    int itemIndex = 0;
                    pnlLayout.Controls.Add(new LiteralControl("<div class=\"box-categories info\">"));
                    string html = string.Empty;
                    var products = DataSource as System.Collections.Generic.List<phukienipadx.Bl.Models.ProductInfo>;
                    foreach (phukienipadx.Bl.Models.ProductInfo item in products)
                    {
                        if (itemIndex > 6 && SessionUtils.Get<bool>("AllCategories")) break;
                        html += GiaPhuc.Helper.ProductHelper.GetProductItemLayout(item.ProductNumber, item.ProductName, item.DetailsUrl, item.ThumbsUrl, item.DisplayPrice, item.IsDiscountItem ? item.DisplayDiscountPrice : string.Empty);
                        if (itemIndex % 3 == 2 || itemIndex == products.Count - 1)
                        {
                            pnlLayout.Controls.Add(new LiteralControl(string.Format(GroupSection, html)));
                            html = string.Empty;
                        }
                        itemIndex++;
                    }
                    if (itemIndex < products.Count)
                    {
                        pnlLayout.Controls.Add(new LiteralControl("<div class=\"view-more\"><a href=\"" + CategoryUrl + "\"><span>>> Xem thêm</span></a></div>"));
                    }
                    pnlLayout.Controls.Add(new LiteralControl("</div>"));
                }
            }
        }

        public string GetParentCategoryName()
        {
            return CategoryName.ToUpper();
        }
    }
}