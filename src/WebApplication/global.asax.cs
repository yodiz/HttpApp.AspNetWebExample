using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using HttpApp.Expose.HttpApplication;

namespace WebApplication
{
    
    public class global : HttpApp.Expose.HttpApplication.HttpApplicationHost<string>
    {
        public global() : base(Example.httpExposeApp, "My Application")
        {
        }
    }
}