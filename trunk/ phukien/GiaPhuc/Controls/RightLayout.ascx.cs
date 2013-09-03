using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GiaPhuc.Data;
using System.Data;
using GiaPhuc.Model;

namespace GiaPhuc.Controls
{
    public partial class RightLayout : System.Web.UI.UserControl
    {

        public IList<EZPages> EZPages
        {
            get { return Session["Pages"] as IList<EZPages>; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ManageHelper.ConnectionString))
                {
                    using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        Session["Pages"] = context.EZPages.Where(x => x.ToCChapter == (int)PageType.Topic).ToList();

                        var queryProducts = from x in context.Products.ToList()
                                            join y in context.ProductsDescription
                                            on x.ProductsID equals y.ProductsID
                                            select new { x, y };

                        var products = from item in queryProducts
                                       where Convert.ToBoolean(item.x.ProductIsAlwaysFreeShipping)
                                       select new ProductModel
                                       {
                                           IsSmall = true,
                                           ProductID = item.x.ProductsID,
                                           ProductCode = item.x.ProductsModel,
                                           ProductName = item.y.ProductsName,
                                           Price = item.x.ProductsPrice,
                                           IsCalledPrice = Convert.ToBoolean(item.x.ProductIsCall),
                                           Specification = item.y.ProductsDescription1,
                                           ImagePath = item.x.ProductsImage,
                                           Url = ("/Pages/ProductDetail.aspx?ID=" + item.x.ProductsID).ParseSimpleURL(item.y.ProductsName),
                                           CartUrl = ("/Pages/CartPage.aspx?ProductID=" + item.x.ProductsID).ParseSimpleURL(item.y.ProductsName),
                                           CategoryID = item.x.MasterCategoriesID
                                       };
                        this.rptHotProducts.DataSource = products.OrderBy(x => x.CategoryID).ThenBy(x => x.Price);
                        this.rptHotProducts.DataBind();
                    }
                }
            }
        }
    }
}