using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models.Interfaces
{
    interface ICategory
    {
        Task AddCategory(string categoryName);

        Task UpdateCategory(string newName);

        Task DeleteCategory();

        Task<List<FullSnippet>> GetCategories();
    }
}
