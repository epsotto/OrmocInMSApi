﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace OrmocInMS
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //this is a test edit
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
