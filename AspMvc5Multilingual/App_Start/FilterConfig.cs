using System.Web.Mvc;
using AspMvc5Multilingual.Attributes;

namespace AspMvc5Multilingual
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LocalizationAttribute("en"), 0);
        }
    }
}