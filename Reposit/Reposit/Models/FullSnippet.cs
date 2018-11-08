using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models
{
    public class FullSnippet
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string CodeBody { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public Language Language { get; set; }
        public string Notes { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Author { get; set; }
        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }

    public enum Language
    {
        [Display(Name="Javascript")]
        JavaScript,
        [Display(Name="Swift")]
        Swift,
        [Display(Name="Java")]
        Java,
        [Display(Name="C++")]
        Cpp,
        [Display(Name="Python")]
        Python,
        [Display(Name="PHP")]
        PHP,
        [Display(Name="Scalia")]
        Scala,
        [Display(Name="Ruby")]
        Ruby,
        [Display(Name="C#")]
        Csharp,
        [Display(Name="HTML")]
        HTML,
        [Display(Name="CSS")]
        CSS,
        [Display(Name="Other")]
        Other
    }
}
