using System;
using System.Web.UI;

namespace GiaPhuc.Controls
{
    public partial class UCProductCategory : System.Web.UI.UserControl
    {
        const string GroupSection = "<ul class=\"section group\">{0}</div>";

        #region Properties

        public string CategoryName { get; set; }
        public object DataSource { get; set; }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (DataSource != null)
                {
                    int group = 0;
                    string html = "<div class=\"box-categories info\">";
                    pnlLayout.Controls.Add(new LiteralControl(html));
                    html = string.Empty;
                    var products = DataSource as System.Collections.Generic.List<phukienipadx.Bl.Models.ProductInfo>;
                    foreach (phukienipadx.Bl.Models.ProductInfo item in products)
                    {
                        html += GiaPhuc.Helper.ProductHelper.GetProductItemLayout(item.ProductNumber, item.ProductName, item.DetailsUrl, item.ThumbsUrl, item.DisplayPrice, item.IsDiscountItem ? item.DisplayDiscountPrice : string.Empty);
                        if (group % 3 == 2 || group == products.Count - 1)
                        {
                            pnlLayout.Controls.Add(new LiteralControl(string.Format(GroupSection, html)));
                            html = string.Empty;
                        }
                        group++;
                    }
                    html = "</div>";
                    pnlLayout.Controls.Add(new LiteralControl(html));
                }
            }
        }

        public string GetParentCategoryName()
        {
            return CategoryName.ToUpper();
        }
    }
}