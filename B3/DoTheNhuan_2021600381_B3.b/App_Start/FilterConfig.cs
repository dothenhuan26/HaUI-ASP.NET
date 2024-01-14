using System.Web;
using System.Web.Mvc;

namespace DoTheNhuan_2021600381_B3.b
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
