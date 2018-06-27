using SwaggerWcf;
using System;
using System.ServiceModel.Activation;
using System.Web.Routing;

namespace MyWcf
{
    public class Global : System.Web.HttpApplication
    {    
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.Add(new ServiceRoute("UserInfoService", new System.ServiceModel.Activation.WebServiceHostFactory(), typeof(UserInfo)));
            RouteTable.Routes.Add(new ServiceRoute("SchoolInfoService", new System.ServiceModel.Activation.WebServiceHostFactory(), typeof(SchoolInfo)));
            RouteTable.Routes.Add(new ServiceRoute("api-docs", new WebServiceHostFactory(), typeof(SwaggerWcfEndpoint)));
       
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}