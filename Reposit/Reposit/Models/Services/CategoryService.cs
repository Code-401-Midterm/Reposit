using Microsoft.EntityFrameworkCore;
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

        public async Task AddCategory(Category newCat)
        {
            _context.Category.Add(newCat);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            Category cat = await GetCategory(id);
            _context.Category.Remove(cat);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FullSnippet>> GetAllSnippetsFromCategory(int? id)
        {
            var result = await _context.FullSnippet.Where(snip => snip.CategoryID == id).ToListAsync();
            return result;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Category> GetCategory(int? id)
        {
            return await _context.Category.FirstOrDefaultAsync(cat => cat.ID == id);
        }

        public async Task UpdateCategory(Category updateCat)
        {
            _context.Category.Update(updateCat);
            await _context.SaveChangesAsync();
        }
        
    }
}
