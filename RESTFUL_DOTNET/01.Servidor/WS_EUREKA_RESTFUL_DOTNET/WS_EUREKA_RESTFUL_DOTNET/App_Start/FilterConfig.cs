﻿using System.Web;
using System.Web.Mvc;

namespace WS_EUREKA_RESTFUL_DOTNET
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
