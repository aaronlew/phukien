using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace GiaPhuc.Helper
{
    public class ProductHelper
    {
        public static string GetProductItemLayout(string code, string name, string url, string imgSrc, string price, string discountPrice = "")
        {
            StringBuilder builder = new StringBuilder("<li class=\"col span_1_of_3\"><div class=\"product-cell\">");

            builder.AppendFormat("<div class=\"description\"><a href=\"{1}\">{2}</a></div><p>{0}</p>", code, url, name);
            builder.AppendFormat("<a href=\"{2}\"><img src=\"{0}\" alt=\"{1}\" title=\"{1}\" /></a>", imgSrc, name, url);
            if (discountPrice != string.Empty) builder.AppendFormat("<div>{0}</div>", discountPrice);
            builder.AppendFormat("<div class=\"price\"><span>{0}</span><a href=\"{1}\"><span>Xem</span></a></div>", price, url);
            builder.Append("<div class=\"clear\"></div></div></li>");

            return builder.ToString();
        }
    }
}