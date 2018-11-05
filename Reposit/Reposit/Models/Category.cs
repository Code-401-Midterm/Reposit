using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }

        public ICollection<FullSnippet> Snippets { get; set; }
    }
}
