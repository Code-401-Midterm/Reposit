using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models
{
    public class ViewModel
    {
        public List<FullSnippet> ApiSnippets { get; set; }

        public List<FullSnippet> WebDbSnippets { get; set; }

        public int CategoryID { get; set; }

    }
}
