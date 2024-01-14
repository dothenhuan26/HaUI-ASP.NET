using System.Web;
using System.Web.Mvc;

namespace DoTheNhuan_2021600381_B3._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
