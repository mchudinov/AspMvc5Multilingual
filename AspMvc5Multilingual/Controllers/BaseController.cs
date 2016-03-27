using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspMvc5Multilingual.Controllers
{
    public abstract class BaseController : Controller
    {
        private string CurrentLanguageCode { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (requestContext.RouteData.Values["lang"] != null && requestContext.RouteData.Values["lang"] as string != "null")
            {
                CurrentLanguageCode = (string)requestContext.RouteData.Values["lang"];
                if (CurrentLanguageCode != null)
                {
                    try
                    {
                        Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(CurrentLanguageCode);
                    }
                    catch (Exception)
                    {
                        throw new NotSupportedException($"Invalid language code '{CurrentLanguageCode}'.");
                    }
                }
            }
            base.Initialize(requestContext);
        }
    }
}