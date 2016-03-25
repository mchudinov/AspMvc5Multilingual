using System;
using System.ComponentModel.DataAnnotations;

namespace AspMvc5Multilingual.Models
{
    public class Widget
    {
        [Required]
        [StringLength(50, ErrorMessage = "Must be at least 5 charachters", MinimumLength = 5)]
        [RegularExpression(@"^[A-Za-z0-9_]+$", ErrorMessage = "Name must contain only letters a-z, numbers and underscore _")]
        public string Name { get; set; }

        public decimal Money { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}