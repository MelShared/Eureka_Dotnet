﻿using System.Web;
using System.Web.Mvc;

namespace EUREKA_RESTFUL_DOTNET_CLIWEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
