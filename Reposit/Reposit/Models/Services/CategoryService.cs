using Reposit.Data;
using Reposit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models.Services
{
    public class CategoryService : ICategory
    {
        private RepositDbContext _context;

        public CategoryService(RepositDbContext context)
        {
            _context = context;
        }

        public Task AddCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory()
        {
            throw new NotImplementedException();
        }

        public Task<List<FullSnippet>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(string newName)
        {
            throw new NotImplementedException();
        }
    }
}
