﻿using System.Web;
using System.Web.Mvc;

namespace PuApi.MicroService.ServiceInstance
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
