using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models
{
    public class FullSnippet
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string CodeBody { get; set; }
        public string Language { get; set; }
        public string Notes { get; set; }
        public string Author { get; set; }
        public Category ID { get; set; }

        public Category Category { get; set; }
    }
}
