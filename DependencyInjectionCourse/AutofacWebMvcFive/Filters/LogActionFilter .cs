using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutofacWebMvcFive.Utilities;

namespace AutofacWebMvcFive.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public IUserProvider UserProvider { set; get; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var username = UserProvider.UserName;
            // log action
        }
    }
}