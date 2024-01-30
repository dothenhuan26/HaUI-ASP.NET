using System.Web;
using System.Web.Mvc;

namespace KT1_DoTheNhuan_2021600381
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
