using Microsoft.EntityFrameworkCore;
using Reposit.Data;
using Reposit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

namespace Reposit.Models.Services
{
    public class FullSnippetService : IFullSnippets
    {
        private RepositDbContext _context;

        public FullSnippetService(RepositDbContext context)
        {
            _context = context;
        }

        public async Task AddSnippet(FullSnippet fullSnippet)
        {
            _context.FullSnippet.Add(fullSnippet);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSnippet(int id)
        {
            FullSnippet snip = await GetSnippet(id);
            _context.FullSnippet.Remove(snip);
            await _context.SaveChangesAsync();
        }

        public async Task<FullSnippet> GetSnippet(int? id)
        {
            return await _context.FullSnippet.FirstOrDefaultAsync(snip => snip.ID == id);
        }

        public async Task<List<FullSnippet>> GetSnippets()
        {
            return await _context.FullSnippet.ToListAsync();
        }

        public async Task UpdateSnippet(FullSnippet fullSnippet)
        {
            _context.FullSnippet.Update(fullSnippet);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Category.ToList();
        }

        public async Task<Category> GetCategoryByID(int id)
        {
            return await _context.Category.FirstOrDefaultAsync(cat => cat.ID == id);
        }

        public async Task<List<FullSnippet>> GetSnippetsFromAPI()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://repositapi.azurewebsites.net");
                    var response = await client.GetAsync("/api/snippet");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawSnippets = JsonConvert.DeserializeObject<List<FullSnippet>>(stringResult);
                    
                    foreach (var item in rawSnippets)
                    {
                        Language language = (Language)Enum.Parse(typeof(Language), item.Language.ToString(), true);
                        item.Language = language;
                        //Enum.TryParse(item.Language, true, out language);

                    }

                    return rawSnippets;

                }
                catch (Exception)
                {
                    throw;
                }


            }
        }
    }
}
