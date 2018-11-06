using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Models.ViewModels
{
    public class SnippetInfoVM
    {
        public Snippet Snippet { get; set; }
        public Author Author { get; set; }
    }
}
