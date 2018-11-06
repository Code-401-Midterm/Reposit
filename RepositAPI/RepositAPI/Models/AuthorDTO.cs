using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Models
{
    public class AuthorDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<SnippetDTO> Snippets { get; set; }
    }
}
