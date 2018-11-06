using Microsoft.EntityFrameworkCore;
using Reposit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Data
{
    public class RepositDbContext : DbContext
    {
        public RepositDbContext(DbContextOptions<RepositDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullSnippet>()
            .Property(f => f.Date)
            .HasColumnType("datetime2");
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<FullSnippet> FullSnippet { get; set; }

    }
}
