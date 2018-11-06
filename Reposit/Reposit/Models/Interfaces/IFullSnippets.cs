using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models.Interfaces
{
    public interface IFullSnippets
    {
        Task AddSnippet(FullSnippet fullSnippet);

        Task UpdateSnippet(FullSnippet fullSnippet);

        Task DeleteSnippet(int id);

        Task<List<FullSnippet>> GetSnippets();

        Task<FullSnippet> GetSnippet(int? id);

        IEnumerable<Category> GetAllCategories();
    }
}
