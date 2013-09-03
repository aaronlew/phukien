using System;
using System.Web.UI.WebControls;
using phukienipadx.Bl;

public partial class Pages_Login : System.Web.UI.Page
{
    const string DestUrl = "/Admin/Pages/ProductManager.aspx";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
    {
        try
        {
                string username = LoginUser.UserName.Trim();
                string password = LoginUser.Password.Trim();

                bool flag = UserImpl.Authenticate(username, password);
                if (flag)
                {
                    e.Authenticated = true;
                    
                    LoginUser.DestinationPageUrl = DestUrl;
                }
                else
                {
                    e.Authenticated = false;
                }
        }
        catch (Exception)
        {
            e.Authenticated = false;
        }
    }
}