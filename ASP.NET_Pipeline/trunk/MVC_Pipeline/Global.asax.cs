using Common.Logging;
using MVC_Pipeline.App_Start;
using MVC_Pipeline.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Pipeline
{
    public class MvcApplication : System.Web.HttpApplication
    {
        ILog log = LogManager.GetLogger("Global.asax");
        protected void Application_Start()
        {
            log.Info("begin application start");
            ControllerBuilder.Current.SetControllerFactory(typeof(MyControllerFactory)); // 自定义控制器工程
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterRoutes(GlobalFilters.Filters);
            log.Info("end application start");
        }
        public override void Init()
        {
            log.Info("begin application Init");
            base.Init();
            log.Info("end application Init");
        }
    }
}
