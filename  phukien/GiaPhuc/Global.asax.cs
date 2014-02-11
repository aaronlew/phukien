using System;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Configuration;
using GiaPhuc.Helper;

namespace GiaPhuc
{
    public class Global : HttpApplication
    {
        public string CompanyName
        {
            get
            {
                var attributes =
                    (AssemblyCompanyAttribute[])
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), true);

                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                else
                {
                    return attributes[0].Company;
                }
            }
        }

        private void Application_Start(object sender, EventArgs e)
        {
            Application["CompanyName"] = CompanyName;
            Application["CKeditor:UserFilesPath"] = "../../../../../img/";

            // Code that runs on application startup
            Application["OnlineUsers"] = 0;

            UrlRouting.Initialize();
        }

        private void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown
            Application["OnlineUsers"] = null;
        }

        private void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
        }

        private void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            Application.Lock();
            int onlineUsers = int.Parse(Application["OnlineUsers"].ToString());
            Application["OnlineUsers"] = ++onlineUsers;
            Application.UnLock();
        }

        private void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
            Application.Lock();
            int onlineUsers = int.Parse(Application["OnlineUsers"].ToString());
            Application["OnlineUsers"] = --onlineUsers;
            Application.UnLock();
        }
    }
}