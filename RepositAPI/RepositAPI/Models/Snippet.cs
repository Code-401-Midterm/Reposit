using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Models
{

     public class Snippet
     {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Date{ get; set; }
        [Required]
        public string CodeBody { get; set; }
        [Required]
        public Language Language { get; set; }
        public string Notes { get; set; }

        public int AuthorID { get; set; }

        public Author Author { get; set; }
    }

     public enum Language
     {
        JavaScript,
        Swift,
        Java,
        Cpp,
        Python,
        PHP,
        Scala,
        Ruby,
        Csharp,
        HTML,
        CSS,
        Other
     }
}
