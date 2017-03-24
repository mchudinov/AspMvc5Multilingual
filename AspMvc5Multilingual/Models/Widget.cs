using System;
using System.ComponentModel.DataAnnotations;
using AspMvc5Multilingual.App_LocalResources;

namespace AspMvc5Multilingual.Models
{
    public class Widget
    {
        [Required(ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "This_field_is_required")]
        [StringLength(50, MinimumLength = 5, ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "Must_be_at_least_5_charachters")]
        [RegularExpression(@"^[A-Za-z0-9_]+$", ErrorMessageResourceType = typeof(GlobalRes), ErrorMessageResourceName = "Must_contain_only_letters")]
        [Display(Name = "Name", ResourceType = typeof(GlobalRes))]
        public string Name { get; set; }

        [Display(Name = "Money", ResourceType = typeof(GlobalRes))]
        public decimal Money { get; set; }

        [Display(Name = "DateTime", ResourceType = typeof(GlobalRes))]
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}