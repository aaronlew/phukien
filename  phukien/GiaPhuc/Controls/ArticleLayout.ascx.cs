using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using phukienipadx.Bl;
using phukienipadx.Core;

namespace GiaPhuc.Controls
{
    public partial class ArticleLayout : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void CreateChildControls()
        {
            this.Controls.Add(new LiteralControl(LayoutSlide()));

            base.CreateChildControls();
        }

        protected string LayoutSlide()
        {
            try
            {
                var items = PostImpl.GetPages((int)PageType.Topic);

                if (items.Count > 0)
                {
                    StringBuilder html = new StringBuilder("<div class='coffee-title'/><div class='tit'><h2>CAFE - TIN TỨC</h2></div>");
                    html.Append("<div class='cycle-pager' id='pager'></div>")
                        .Append("</div>")
                        .Append("<div class='articles' data-cycle-fx='carousel' data-cycle-timeout='0' data-cycle-carousel-visible='3' data-cycle-slides='> div' data-cycle-next='#next' data-cycle-prev='#prev' data-cycle-pager='#pager'>");
                    for (int i = 0; i < items.Count; i++)
                    {
                        html.Append("<div class='item'>");
                        html.Append("<div class='img'>");
                        html.AppendFormat("<a href='/bai-viet/{0}' class='overlay'><img src='{1}' /></a>", items[i].Url, items[i].Image_Roll);
                        html.Append("</div>");
                        html.Append("<div class='desc'>");
                        html.AppendFormat("<span class='tit'><a href='/bai-viet/{0}'><h2>{1}</h2></a></span>", items[i].Url, items[i].Title);
                        html.AppendFormat("<div class='sapo'><span>{0}</span></div>", items[i].Sapo);
                        html.Append("</div>");
                        html.Append("</div>");
                    }

                    html.Append("</div>")
                        .Append("<div class='center'>")
                        .Append("<a href='#' id='prev' class='nav'><div class='arrow-conceal'></div></a><a href='#' id='next' class='nav'><div class='arrow-conceal'></div></a>")
                        .Append("</div>");

                    return html.ToString();
                }
                else { return string.Empty; }
            }
            catch
            {
                Response.Redirect("/loi-404");
                return string.Empty;
            }
        }
    }
}