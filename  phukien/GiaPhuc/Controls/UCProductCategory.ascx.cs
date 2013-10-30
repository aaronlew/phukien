using System;
using System.Web.UI;
using GiaPhuc.Utility;

namespace GiaPhuc.Controls
{
    public partial class UCProductCategory : System.Web.UI.UserControl
    {
        const string GroupSection = "<ul class=\"section group\">{0}</ul>";
        const int PageSize = 4;
        const int ItemPerRow = 4;

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
                        if (itemIndex > PageSize && SessionUtils.Get<bool>("AllCategories")) break;
                        html += GiaPhuc.Helper.ProductHelper.GetProductItemLayout(ItemPerRow, item.ProductNumber, item.ProductName, item.DetailsUrl, item.ThumbsUrl, item.DisplayPrice, item.IsDiscountItem ? item.DisplayDiscountPrice : string.Empty);
                        if (itemIndex % ItemPerRow == ItemPerRow - 1 || itemIndex == products.Count - 1)
                        {
                            pnlLayout.Controls.Add(new LiteralControl(string.Format(GroupSection, html)));
                            html = string.Empty;
                        }
                        itemIndex++;
                    }
                    if (itemIndex < products.Count)
                    {
                        pnlLayout.Controls.Add(new LiteralControl("<div class=\"view-more\"><a target=\"_blank\" href=\"" + CategoryUrl + "\"><span>>> Xem thêm</span></a></div>"));
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