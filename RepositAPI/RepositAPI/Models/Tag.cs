using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Models
{
    public class Tag
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<SnippetTag> Snippets { get; set; }
    }
}
