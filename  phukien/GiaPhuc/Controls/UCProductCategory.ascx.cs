using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using GiaPhuc.Helper;
using GiaPhuc.Utility;
using phukienipadx.Bl.Models;

namespace GiaPhuc.Controls
{
    public partial class UCProductCategory : UserControl
    {
        private const string GroupSection = "<ul class=\"section group\">{0}</ul>";
        private const int PageSize = 4;
        private const int ItemPerRow = 4;

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
                    var products = DataSource as List<ProductInfo>;
                    if (products != null && products.Count > 0)
                    {
                        var htmlBuilder = new StringBuilder("<div class='box-heading'><h2>");
                        htmlBuilder.AppendFormat("<span>{0}</span>", CategoryName);
                        htmlBuilder.Append("</h2></div>");

                        htmlBuilder.Append("<div class=\"box-categories info\">");
                        foreach (ProductInfo item in products)
                        {
                            if (itemIndex > PageSize && SessionUtils.Get<bool>("AllCategories")) break;
                            html += ProductHelper.GetProductItemLayout(ItemPerRow, item.ProductNumber, item.ProductName,
                                item.DetailsUrl, item.ThumbsUrl, item.DisplayPrice,
                                item.IsDiscountItem ? item.DisplayDiscountPrice : string.Empty);
                            if (itemIndex%ItemPerRow == ItemPerRow - 1 || itemIndex == products.Count - 1)
                            {
                                htmlBuilder.AppendFormat(GroupSection, html);
                                html = string.Empty;
                            }
                            itemIndex++;
                        }
                        if (itemIndex < products.Count)
                        {
                            htmlBuilder.AppendFormat(
                                "<div class=\"view-more\"><a href=\"{0}\"><span>>> Xem thêm</span></a></div>",
                                CategoryUrl);
                        }
                        htmlBuilder.Append("</div>");

                        pnlLayout.Controls.Add(new LiteralControl(htmlBuilder.ToString()));
                    }
                }
            }
        }
    }
}