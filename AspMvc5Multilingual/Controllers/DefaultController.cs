using System;
using System.Globalization;
using System.Web.Mvc;
using AspMvc5Multilingual.Attributes;
using AspMvc5Multilingual.Models;

namespace AspMvc5Multilingual.Controllers
{
    //[Localization("en")]
    public class DefaultController : BaseController
    {
        public ActionResult Index(Widget w)
        {
            NumberFormatInfo nfi = new NumberFormatInfo {CurrencySymbol = "€"};
            ViewBag.nfi = nfi;
            var widget = new Widget {Money = (new Random().Next(1, 100000))};
            return View(widget);
        }
    }
}