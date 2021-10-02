using System.Web;
using System.Web.Mvc;

namespace LabNet2021.Tp8.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
