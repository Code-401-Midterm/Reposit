using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Models
{
    public class SnippetDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string CodeBody { get; set; }
        public Language Language { get; set; }
        public string Notes { get; set; }
        public string Author { get; set; }
        public int AuthorID { get; set; }
    }
}
