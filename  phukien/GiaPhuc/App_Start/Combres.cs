[assembly: WebActivator.PreApplicationStartMethod(typeof(GiaPhuc.App_Start.Combres), "PreStart")]
namespace GiaPhuc.App_Start {
	using System.Web.Routing;
	using global::Combres;
	
    public static class Combres {
        public static void PreStart() {
            RouteTable.Routes.AddCombresRoute("Combres");
        }
    }
}