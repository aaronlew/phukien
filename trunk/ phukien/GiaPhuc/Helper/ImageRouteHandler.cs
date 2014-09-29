using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Routing;
using phudieuhungthinh.BL;

namespace phudieuhungthinh.Helpers
{
    public class ImageRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new ImageHandler(requestContext);
        }
    }

    public class ImageHandler : IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //write your handler implementation here.
        }

        #endregion

        public ImageHandler(RequestContext context)
        {
            ProcessRequest(context);
        }

        private static void ProcessRequest(RequestContext requestContext)
        {
            var response = requestContext.HttpContext.Response;
            var request = requestContext.HttpContext.Request;
            var server = requestContext.HttpContext.Server;
            var validRequestFile = requestContext.RouteData.Values["filename"].ToString();

            //response.Clear();
            //if (request.Url != null) response.ContentType = GetContentType(request.Url.ToString());

            if (request.ServerVariables["HTTP_REFERER"] != null &&
                request.ServerVariables["HTTP_REFERER"].Contains("phudieudangcap.vn") &&
                request.Url != null)
            {
                if (request.Url.AbsolutePath.StartsWith("/hinh-anh-noi-bat/dieu-khac/"))
                {
                    var path = server.MapPath("~/images/highlight-products/");
                    response.TransmitFile(path + validRequestFile);
                }
                else if (request.Url.AbsolutePath.StartsWith("/hinh-anh/phu-dieu/"))
                {
                    var im = new ProductImpl();
                    var path = server.MapPath("~/images/products/thumb/");
                    response.TransmitFile(path + im.GetImage(validRequestFile));
                }
                else if (request.Url.AbsolutePath.StartsWith("/hinh-anh/dieu-khac/"))
                {
                    var im = new ProductImpl();
                    var path = server.MapPath("~/images/products/copyright/");
                    response.TransmitFile(path + im.GetImage(validRequestFile));
                }
            }
            else
            {
                //response.TransmitFile(path + invalidRequestFile);
            }
            response.End();
        }

        private static string GetContentType(string url)
        {
            switch (Path.GetExtension(url))
            {
                case ".gif":
                    return "Image/gif";
                case ".jpeg":
                    return "Image/jpeg";
                case ".jpg":
                    return "Image/jpeg";
                case ".png":
                    return "Image/png";
            }
            return null;
        }
    }
}