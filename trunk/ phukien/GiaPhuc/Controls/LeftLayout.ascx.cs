using System;
using GiaPhuc.Utility;

namespace GiaPhuc.Controls
{
    public partial class LeftLayout : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Hot products
                this.datDefault.DataSource = SessionManager.SpecProducts;
                this.datDefault.DataBind();
            }
        }
    }
}