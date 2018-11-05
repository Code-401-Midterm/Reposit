using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Models
{
    public class SnippetTag
    {
        public int SnippetID { get; set; }
        public int TagID { get; set; }

        public Snippet Snippet { get; set; }
        public Tag Tag { get; set; }
    }
}
