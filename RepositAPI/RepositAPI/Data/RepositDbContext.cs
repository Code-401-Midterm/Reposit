using Microsoft.EntityFrameworkCore;
using RepositAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositAPI.Data
{
    public class RepositDbContext : DbContext
    {
        public RepositDbContext(DbContextOptions<RepositDbContext> options) : base(options)
        {

        }

        public DbSet<Snippet> Snippets { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<SnippetTag> SnippetTags { get; set; }
    }
}
