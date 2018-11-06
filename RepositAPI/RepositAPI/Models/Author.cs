using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Snippet> Snippets { get; set; }
    }
}
