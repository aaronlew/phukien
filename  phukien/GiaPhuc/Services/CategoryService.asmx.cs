using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.Web.Script.Services;
using GiaPhuc.App_Data;
using GiaPhuc.Helper;

namespace GiaPhuc.Services
{
    /// <summary>
    /// Summary description for CMS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CategoryService : System.Web.Services.WebService
    {

        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<CategoryBrief> LoadCategories()
        {
            List<CategoryBrief> list = CategoryHelper.GetCategories().ToList();
            return list;
        }
    }
}
