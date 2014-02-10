using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GiaPhuc.Helper;
using System.Web.Routing;

namespace GiaPhuc.Pages
{
    public class ParentPage : System.Web.UI.Page, IRoutablePage
    {
        protected RequestContext requestContext;

        protected object RouteValue(string key)
        {
            if (requestContext.RouteData.Values.ContainsKey(key))
                return requestContext.RouteData.Values[key];
            else
                return null;
        }

        #region IRoutablePage Members

        public RequestContext RequestContext
        {
            set { requestContext = value; }
        }

        #endregion
    }
}