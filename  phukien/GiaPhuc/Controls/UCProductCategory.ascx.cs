using System;
using System.Web.UI;
using GiaPhuc.Utility;
using System.Text;

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
                    string html = string.Empty;
                    var products = DataSource as System.Collections.Generic.List<phukienipadx.Bl.Models.ProductInfo>;
                    if (products.Count > 0)
                    {
                        StringBuilder htmlBuilder = new StringBuilder("<div class='box-heading'>");
                        htmlBuilder.Append(CategoryName);
                        htmlBuilder.Append("</div>");

                        htmlBuilder.Append("<div class=\"box-categories info\">");
                        foreach (phukienipadx.Bl.Models.ProductInfo item in products)
                        {
                            if (itemIndex > PageSize && SessionUtils.Get<bool>("AllCategories")) break;
                            html += GiaPhuc.Helper.ProductHelper.GetProductItemLayout(ItemPerRow, item.ProductNumber, item.ProductName, item.DetailsUrl, item.ThumbsUrl, item.DisplayPrice, item.IsDiscountItem ? item.DisplayDiscountPrice : string.Empty);
                            if (itemIndex % ItemPerRow == ItemPerRow - 1 || itemIndex == products.Count - 1)
                            {
                                htmlBuilder.AppendFormat(GroupSection, html);
                                html = string.Empty;
                            }
                            itemIndex++;
                        }
                        if (itemIndex < products.Count)
                        {
                            htmlBuilder.AppendFormat("<div class=\"view-more\"><a target=\"_blank\" href=\"{0}\"><span>>> Xem thêm</span></a></div>", CategoryUrl);
                        }
                        htmlBuilder.Append("</div>");

                        pnlLayout.Controls.Add(new LiteralControl(htmlBuilder.ToString()));
                    }
                }
            }
        }
    }
}