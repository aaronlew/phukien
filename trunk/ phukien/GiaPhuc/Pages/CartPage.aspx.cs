using System;
using System.IO;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using GiaPhuc.App_Data;
using GiaPhuc.Utility;
using phukienipadx.Bl;
using phukienipadx.Bl.Models;
using phukienipadx.Core;
using System.Web;
using GiaPhuc.Helper;
using System.Text;

namespace GiaPhuc.Pages
{
    public partial class CartPage : ParentPage
    {
        #region Properties

        // Old ID
        public string ID
        {
            get
            {
                var val = RouteValue("id");
                if (val == null) return null;
                return val.ToString();
            }
        }

        public string Url
        {
            get
            {
                var val = RouteValue("url");
                if (val == null) return null;
                return val.ToString();
            }
        } 

        #endregion

        #region Event Methods

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ID != null)
                {
                    Response.Status = "301 Moved Permanently";
                    Response.AddHeader("Location", "/gio-hang/" + ProductImpl.GetProductUrl(int.Parse(ID)));
                    Response.End();
                }

                Title = "CỬA HÀNG TINH TẾ (NICE STORE) - PHỤ KIỆN IPAD - GIỎ HÀNG";

                if (!string.IsNullOrEmpty(Url))
                {
                    ProductInfo product = ProductImpl.GetProductDetails(Url);

                    if (!SessionManager.Cart.ContainsKey(product.ProductId))
                    {
                        SessionManager.Cart.Add(product.ProductId, new ShopCart
                                                       {
                                                           ProductId = product.ProductId,
                                                           ProductUrl = product.DetailsUrl,
                                                           ProductNumber = product.ProductNumber,
                                                           ProductName = product.ProductName,
                                                           Price = product.Price,
                                                           ImagePath = product.ImageUrl,
                                                           Quantity = 1
                                                       });
                    }
                    else
                    {
                        SessionManager.Cart[product.ProductId].Quantity++;
                    }

                    // Back to home page
                    Response.Redirect("/gio-hang");
                }
            }
        }

        protected void sendButton_Click(object sender, EventArgs e)
        {

            string filename = "template/shopcarttemplate.htm";
            string filePath = HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath.Replace("/", "\\")) + "\\" + filename;
            string body = DataHelper.ReadTemplateFile(filePath);
            string orderNumber = Guid.NewGuid().ToString().Replace('-', '/').ToUpper();
            string shippingAddress = this.txtAddress.Text;
            if (this.ddlProvince.SelectedIndex > 0) shippingAddress += ", [" + this.ddlProvince.SelectedItem.Text + "]";

            body = body.Replace("[OrderNumber]", orderNumber);
            body = body.Replace("[CustomerName]", this.txtCustomerName.Text);
            body = body.Replace("[PaidMethod]", this.ddlPaidMethod.SelectedItem.Text);
            body = body.Replace("[ShipMethod]", this.ddlShipMethod.SelectedItem.Text);
            body = body.Replace("[ShippingAddress]", shippingAddress);
            body = body.Replace("[Phone]", this.txtPhone.Text);
            body = body.Replace("[OrderDate]", DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"));
            body = body.Replace("[Email]", this.txtEmail.Text);
            body = body.Replace("[Note]", this.txtMemo.Text);

            var detailBody = new StringBuilder();
            foreach (var item in SessionManager.Cart.Values)
            {
                detailBody.Append("<tr>");
                detailBody.AppendFormat("<td><a href=\"http://phukienipadx.com/{0}\" title=\"{1}\">{1}</a></td>", item.ProductUrl, item.ProductName);
                detailBody.AppendFormat("<td align=\"right\">{0:#,##0}</td>", item.Price);
                detailBody.AppendFormat("<td align=\"center\">{0:#,##0}</td>", item.Quantity);
                detailBody.AppendFormat("<td align=\"right\">{0:#,##0}</td>", item.Price * (decimal)item.Quantity);
                detailBody.Append("</tr>");
            }

            body = body.Replace("[Details]", detailBody.ToString());


            var mail = new SendMail(Define.Host, Define.Port, Define.Email, Define.Password, true);
            mail.Send(Define.CompanyName, this.txtEmail.Text.Trim(), "Đơn hàng từ phukienipadx.com", body, true,
                      null, Define.HiddenEmail.Split(','));

            //    form.Dispose();
            //}

            SessionManager.Cart.Clear();

            Alert.Show("Chúng tôi đã nhận được đơn hàng của quý khách, chúng tôi sẽ liên lạc với quý khách để xác nhận đơn hàng! Cám ơn quý khách!");
            Response.Redirect("/");
        }

        #endregion
    }
}