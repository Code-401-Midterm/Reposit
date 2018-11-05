using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Models
{

     public class Snippet
     {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime date { get; set; }
        public string CodeBody { get; set; }
        public Language Language { get; set; }
        public string Notes { get; set; }

        public ICollection<SnippetTag> SnippetTags { get; set; }
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
