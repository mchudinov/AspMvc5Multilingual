using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspMvc5Multilingual.Controllers
{
    public abstract class BaseController : Controller
    {
        public string CurrentLanguageCode { get; protected set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (requestContext.RouteData.Values["lang"] != null && requestContext.RouteData.Values["lang"] as string != "null")
            {
                CurrentLanguageCode = requestContext.RouteData.Values["lang"] as string;
                if (CurrentLanguageCode != null)
                {
                    var ci = new CultureInfo(CurrentLanguageCode);
                    Thread.CurrentThread.CurrentUICulture = ci;
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name);
                }
            }
            base.Initialize(requestContext);
        }
    }
}