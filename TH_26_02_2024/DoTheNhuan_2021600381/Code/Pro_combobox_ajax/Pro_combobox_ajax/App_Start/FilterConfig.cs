﻿using System.Web;
using System.Web.Mvc;

namespace Pro_combobox_ajax
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
