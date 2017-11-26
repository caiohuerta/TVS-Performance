using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace IdalenBackendServices.Filters
{
    public class LogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            DateTime dateTime = DateTime.Now;
            try
            {
                Logs.EventLoghelper.WriteBodyLog("InitialTimestamp: " + dateTime.ToString() + "\n");
            }
            catch (Exception e) {
                String msg = e.Message;
            }           

        }
    }
}