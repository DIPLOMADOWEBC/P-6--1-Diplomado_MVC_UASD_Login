using System.Web;
using System.Web.Mvc;

namespace P_6__1_Diplomado_MVC_UASD_Login
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
