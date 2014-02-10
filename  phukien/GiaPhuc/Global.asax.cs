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

        //private void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    //Get the current http context
        //    HttpContext inRequest = HttpContext.Current;

        //    //Get the current path
        //    string oldPath = inRequest.Request.Path.ToLower();

        //    string[] urls = inRequest.Request.RawUrl.TrimStart('/').Split('/');

        //    //Check the path whether it is a contextual path
        //    if (oldPath.EndsWith(".html")
        //        || (oldPath.EndsWith(".aspx") && urls.Length > 3))
        //    {
        //        string path = urls[0];

        //        path = "/" + path + "/";

        //        string newPath = WebConfigurationManager.AppSettings[path];

        //        if (null != newPath)
        //        {
        //            var stringBuilder = new StringBuilder();
        //            for (int i = 1; i < urls.Length - 1; i += 2)
        //            {
        //                if (i > 1)
        //                {
        //                    stringBuilder.Append("&");
        //                }
        //                stringBuilder.Append(urls[i]);
        //                stringBuilder.Append("=");
        //                stringBuilder.Append(urls[i + 1]);
        //            }

        //            //Rewrite the path with the actual path
        //            inRequest.RewritePath(newPath.TrimStart('.'), string.Empty, stringBuilder.ToString());
        //        }
        //    }
        //}

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