using System;
using System.Web.Mvc;
using AspMvc5Multilingual.Models;

namespace AspMvc5Multilingual.Controllers
{
    public class DefaultController : BaseController
    {
        public ActionResult Index(Widget w)
        {
            ViewBag.Language = CurrentLanguageCode;
            var widget = new Widget {Money = (new Random().Next(1, 100000))};
            return View(widget);
        }
    }
}