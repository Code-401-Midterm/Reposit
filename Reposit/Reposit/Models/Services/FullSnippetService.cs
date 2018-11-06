using Reposit.Data;
using Reposit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models.Services
{
    public class FullSnippetService : IFullSnippets
    {
        private RepositDbContext _context;

        public FullSnippetService(RepositDbContext context)
        {
            _context = context;
        }

        public Task AddSnippet(FullSnippet fullSnippet)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSnippet(FullSnippet fullSnippet)
        {
            throw new NotImplementedException();
        }

        public Task<FullSnippet> GetSnippet(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FullSnippet>> GetSnippets()
        {
            throw new NotImplementedException();
        }

        public Task UpdateSnippet(FullSnippet fullSnippet)
        {
            throw new NotImplementedException();
        }
    }
}
