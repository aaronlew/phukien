using System.Web.Routing;
using GiaPhuc.Helper;

namespace GiaPhuc.Pages
{
    public class ParentPage : System.Web.UI.Page, IRoutablePage
    {
        private RequestContext _requestContext;

        protected object RouteValue(string key)
        {
            if (_requestContext != null && _requestContext.RouteData.Values.ContainsKey(key))
                return _requestContext.RouteData.Values[key];
            return null;
        }

        #region IRoutablePage Members

        public RequestContext RequestContext
        {
            set { _requestContext = value; }
        }

        #endregion
    }
}