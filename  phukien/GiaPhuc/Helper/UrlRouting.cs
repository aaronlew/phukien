using System.Linq;
using System.Web.Routing;

namespace GiaPhuc.Helper
{
    public class UrlRouting
    {
        public static void Initialize()
        {
            //RouteTable.Routes.Clear();
            RegisterRoutes(RouteTable.Routes);
        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            // Do not use url routing for requests with .axd/.asmx/.ico extensions
            // This prevents ASP.NET from having to do File.Exists check
            routes.Add("ignoreAXD", new Route("{resource}.axd/{*pathInfo}", new StopRoutingHandler()));
            routes.Add("ignoreASMX", new Route("{resource}.asmx/{*pathInfo}", new StopRoutingHandler()));
            routes.Add("ignoreICO", new Route("{resource}.ico/{*pathInfo}", new StopRoutingHandler()));

            // Added to solve a issue with http://(www.)domain.ext/ rendering 404
            routes.Add("Home", new Route("", new StopRoutingHandler()));
            
            // Ignore non-virtual system folders
            routes.Add("ignoreAdmin", new Route("admin/{*pathInfo}", new StopRoutingHandler()));
            routes.Add("ignoreAPI", new Route("api/{*pathInfo}", new StopRoutingHandler()));
            routes.Add("ignoreLogin", new Route("login/{*pathInfo}", new StopRoutingHandler()));
            routes.Add("ignoreUtility", new Route("__utility/{*pathInfo}", new StopRoutingHandler()));
            routes.Add("ignoreFiles", new Route("files/{*pathInfo}", new StopRoutingHandler()));

            routes.Add("MyHome", new Route("trang-chu", new CustomRouteHandler("~/Default.aspx")));
            routes.Add("About", new Route("gioi-thieu", new CustomRouteHandler("~/Pages/AboutPage.aspx")));
            routes.Add("Contact", new Route("lien-he", new CustomRouteHandler("~/Pages/ContactPage.aspx")));
            routes.Add("News", new Route("tin-tuc", new CustomRouteHandler("~/Pages/NewsPage.aspx")));
            routes.Add("Buy", new Route("mua-hang", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Manual", new Route("su-dung", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Warranty", new Route("bao-hanh", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Partner", new Route("doi-tac", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Private", new Route("bao-mat", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Ship", new Route("van-chuyen", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Return", new Route("doi-tra", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Error404", new Route("loi-404", new CustomRouteHandler("~/errors/404.aspx")));
            routes.Add("Admin", new Route("quantri", new CustomRouteHandler("~/Admin/Default.aspx")));

            routes.Add("thumbs", new Route("hinh-anh/phu-kien-nho/{filename}", new ImageRouteHandler()));
            routes.Add("originalImages", new Route("hinh-anh/phu-kien/{filename}", new ImageRouteHandler()));
            
            // Old url
            routes.Add("Category99", new Route("trang-chu/CategoryID/{id}/{text}.html", new CustomRouteHandler("~/Pages/CategoryPage.aspx")));
            routes.Add("Category98", new Route("trang-chu/CategoryID/{id}/{text}.aspx", new CustomRouteHandler("~/Pages/CategoryPage.aspx")));
            routes.Add("Product99", new Route("bao-da-ipad/ID/{id}/{text}.html", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Product98", new Route("phu-kien-ipad/ID/{id}/{text}.html", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Product96", new Route("baoda/ID/{id}/{text}.html", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Product88", new Route("phukien/ID/{id}/{text}.html", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Product86", new Route("bao-da-ipad/ID/{id}/{text}.aspx", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Product85", new Route("phu-kien-ipad/ID/{id}/{text}.aspx", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Product83", new Route("baoda/ID/{id}/{text}.aspx", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Product82", new Route("phukien/ID/{id}/{text}.aspx", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Cart99", new Route("gio-hang/ProductID/{id}/{text}.html", new CustomRouteHandler("~/Pages/CartPage.aspx")));
            routes.Add("Topic99", new Route("chuyen-muc/ID/{id}/{text}.html", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Topic98", new Route("chuyen-muc/ID/{id}/{text}.aspx", new CustomRouteHandler("~/Pages/TopicPage.aspx")));

            routes.Add("Search", new Route("q/{keyword}", new CustomRouteHandler("~/Default.aspx")));
            routes.Add("Category", new Route("nhom-hang/{url}", new CustomRouteHandler("~/Pages/CategoryPage.aspx")));
            routes.Add("Category1", new Route("nhom-hang/{url}/{page}", new CustomRouteHandler("~/Pages/CategoryPage.aspx")));

            routes.Add("Cart", new Route("gio-hang", new CustomRouteHandler("~/Pages/CartPage.aspx")));
            routes.Add("Cart1", new Route("gio-hang/{url}", new CustomRouteHandler("~/Pages/CartPage.aspx")));

            routes.Add("Product", new Route("san-pham/{url}", new CustomRouteHandler("~/Pages/ProductPage.aspx")));
            routes.Add("Product1", new Route("san-pham/{url}/{page}", new CustomRouteHandler("~/Pages/ProductPage.aspx")));

            routes.Add("Topic", new Route("bai-viet/{url}", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
            routes.Add("Topic1", new Route("bai-viet/{url}/{page}", new CustomRouteHandler("~/Pages/TopicPage.aspx")));
        }

        public static void AddRoute(Route route)
        {
            // Ensure route does not already exist
            if (RouteTable.Routes.Cast<Route>().Any(r => r.Url == route.Url))
            {
                return;
            }

            RouteTable.Routes.Add(route);
        }
    }
}