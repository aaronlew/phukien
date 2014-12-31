using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using phukienipadx.Core;

namespace GiaPhuc.Controls
{
    public partial class ArticleLayout : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected override void CreateChildControls()
        {
            Controls.Add(new LiteralControl(LayoutSlide()));

            base.CreateChildControls();
        }

        protected string LayoutSlide()
        {
            try
            {
                IList<PageInfo> items = PostImpl.GetPages((int) PageType.Topic);

                if (items.Count > 0)
                {
                    var html =
                        new StringBuilder("<div class='coffee-title'/><div class='tit'><h2>CAFE - TIN TỨC</h2></div>");
                    html.Append("<div class='cycle-pager' id='pager'></div>")
                        .Append("</div>")
                        .Append(
                            "<div class='articles' data-cycle-fx='carousel' data-cycle-timeout='0' data-cycle-carousel-visible='3' data-cycle-slides='> div' data-cycle-next='#next' data-cycle-prev='#prev' data-cycle-pager='#pager'>");
                    foreach (PageInfo t in items)
                    {
                        html.Append("<div class='item'>");
                        html.Append("<div class='img'>");
                        html.AppendFormat(
                            "<a href='/bai-viet/{0}' class='overlay'><img data-src='{1}' src='/Images/ajax-loader.gif' alt='tin tuc tinh te' /></a>",
                            t.Url, t.Image_Roll);
                        html.Append("</div>");
                        html.Append("<div class='desc'>");
                        html.AppendFormat("<span class='tit'><a href='/bai-viet/{0}'><h2>{1}</h2></a></span>", t.Url,
                            t.Title);
                        html.AppendFormat("<div class='sapo'><span>{0}</span></div>", t.Sapo);
                        html.Append("</div>");
                        html.Append("</div>");
                    }

                    html.Append("</div>")
                        .Append("<div class='center'>")
                        .Append(
                            "<a href='#' id='prev' class='nav'><div class='arrow-conceal'></div></a><a href='#' id='next' class='nav'><div class='arrow-conceal'></div></a>")
                        .Append("</div>");

                    return html.ToString();
                }
                return string.Empty;
            }
            catch
            {
                Response.Redirect("/loi-404");
                return string.Empty;
            }
        }
    }
}