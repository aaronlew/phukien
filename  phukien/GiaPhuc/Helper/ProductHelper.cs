using System.Text;

namespace GiaPhuc.Helper
{
    public class ProductHelper
    {
        public static string GetProductItemLayout(int itemPerRow, string code, string name, string url, string imgSrc,
            string price, string discountPrice = "")
        {
            var builder =
                new StringBuilder("<li class=\"col span_1_of_" + itemPerRow + "\"><div class=\"product-cell\">");

            builder.AppendFormat("<p>{0}</p>", code);
            builder.AppendFormat("<a href=\"{2}\"><img data-src=\"{0}\" src=\"/images/ajax-loader.gif\" alt=\"{1}\" title=\"{1}\" /></a>", "/hinh-anh/phu-kien-nho/" + url, name, url);
            builder.AppendFormat("<div class=\"description\"><a href=\"{0}\">{1}</a></div>", url, name);
            if (discountPrice != string.Empty) builder.AppendFormat("<div>{0}</div>", discountPrice);
            builder.AppendFormat("<div class=\"price\"><span>{0}</span><a href=\"{1}\"><span>Xem</span></a></div>",
                price, url);
            builder.Append("<div class=\"clear\"></div></div></li>");

            return builder.ToString();
        }
    }
}