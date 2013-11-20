﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace GiaPhuc.Helper
{
    public class ProductHelper
    {
        public static string GetProductItemLayout(int itemPerRow, string code, string name, string url, string imgSrc, string price, string discountPrice = "")
        {
            StringBuilder builder = new StringBuilder("<li class=\"col span_1_of_" + itemPerRow + "\"><div class=\"product-cell\">");

            builder.AppendFormat("<p>{0}</p>", code);
            builder.AppendFormat("<a target=\"_blank\" href=\"{2}\"><img src=\"{0}\" alt=\"{1}\" title=\"{1}\" /></a>", imgSrc, name, url);
            builder.AppendFormat("<div class=\"description\"><a target=\"_blank\" href=\"{0}\">{1}</a></div>", url, name);
            if (discountPrice != string.Empty) builder.AppendFormat("<div>{0}</div>", discountPrice);
            builder.AppendFormat("<div class=\"price\"><span>{0}</span><a target=\"_blank\" href=\"{1}\"><span>Xem</span></a></div>", price, url);
            builder.Append("<div class=\"clear\"></div></div></li>");

            return builder.ToString();
        }
    }
}