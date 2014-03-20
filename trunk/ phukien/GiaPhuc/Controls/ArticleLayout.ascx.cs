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

        protected string LayoutSlide()
        {
            try
            {
                var items = PostImpl.GetPages((int)PageType.Topic);

                if (items.Count > 0)
                {
                    StringBuilder html = new StringBuilder("<div class='articles' data-cycle-auto-height='3:1' data-cycle-fx='carousel' data-cycle-timeout='3000' data-cycle-timeout='0' data-cycle-carousel-visible='3' data-cycle-slides='> div' data-cycle-next='#next' data-cycle-prev='#prev' data-cycle-pager='#pager'>");

                    for (int i = 0; i < items.Count; i++)
                    {
                        html.Append("<div class='item'>");
                        html.Append("<div class='img'>");
                        html.AppendFormat("<a href='/san-pham/{0}' class='overlay'><img src='{1}' /></a>", items[i].Url, items[i].Image_Roll);
                        html.Append("</div>");
                        html.Append("<div class='desc'>");
                        html.AppendFormat("<div class='tit'><h2>{0}</h2></div>", items[i].Title);
                        html.AppendFormat("<div class='sapo'><span>{0}</span></div>", items[i].Sapo);
                        html.Append("</div>");
                        html.Append("</div>");
                    }

                    html.Append("</div>");
                    html.Append("<div class='center'>");
                    html.Append("<a href='#' id='prev' class='nav'></a><a href='#' id='next' class='nav'></a>");
                    html.Append("</div>");
                    html.Append("<div class='cycle-pager' id='pager'>");
                    html.Append("</div>");

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