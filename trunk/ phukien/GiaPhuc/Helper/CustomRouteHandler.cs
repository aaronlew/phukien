using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.Compilation;

namespace GiaPhuc.Helper
{
    public interface IRoutablePage
    {
        RequestContext RequestContext { set; }
    }

    public class CustomRouteHandler : IRouteHandler
    {
        public CustomRouteHandler(string virtualPath)
        {
            this.VirtualPath = virtualPath;
        }

        public string VirtualPath { get; private set; }

        public IHttpHandler GetHttpHandler(RequestContext
              requestContext)
        {
            //var id = requestContext.RouteData.Values["id"] != null ? requestContext.RouteData.Values["id"].ToString() : null;
            
            var page = BuildManager.CreateInstanceFromVirtualPath
                 (VirtualPath, typeof(Page)) as IHttpHandler;

            if (page != null)
            {
                var routablePage = page as IRoutablePage;

                if (routablePage != null) routablePage.RequestContext = requestContext;
            }

            return page;
        }
    }
}