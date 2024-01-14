using System.Web;
using System.Web.Mvc;

namespace DoTheNhuan_2021600381_proj6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
