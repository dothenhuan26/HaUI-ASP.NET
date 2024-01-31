using System.Web;
using System.Web.Mvc;

namespace TH_2021600381_DoTheNhuan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
