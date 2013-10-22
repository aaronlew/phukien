using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GiaPhuc.Controls
{
    public partial class UCProductCell : System.Web.UI.UserControl
    {
        #region Properties

        public string PhotoPath { get; set; }
        public string ProductUrl { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDiscountPrice { get; set; }
        public string ProductPrice { get; set; }
        public string ProductClass { get; set; }
        public bool IsDiscountItem { private get; set; }
        public string AddToCartUrl { get; set; }

        #endregion

        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "section group");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "product-cell");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "col span_1_of_2");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.WriteLine("<a target=\"_blank\" href=\"{2}\"><img src=\"{0}\" alt=\"{1}\" title=\"{1}\" /></a>", PhotoPath, ProductName, ProductUrl);
            writer.RenderEndTag();
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "col span_1_of_2");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "description");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.WriteLine("<a target=\"_blank\" href=\"{1}\">{2}</a><p>{0}</p>", ProductCode, ProductUrl, ProductName.Length > 30 ? ProductName.Substring(0, 30) + " ..." : ProductName);
            if (IsDiscountItem)
                writer.WriteLine("<div>{0}</div>", ProductDiscountPrice);
            writer.WriteLine("<div class=\"price\"><span>{0}</span></div>", ProductPrice);
            writer.RenderEndTag();
            writer.RenderEndTag();
            writer.WriteLine("<div class=\"clear\"></div>");
            writer.RenderEndTag();
            writer.RenderEndTag();
            base.Render(writer);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}