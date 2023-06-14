using System.Web;
using System.Web.Mvc;

namespace CRUDMVC.NET_FRAMEWORK
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
