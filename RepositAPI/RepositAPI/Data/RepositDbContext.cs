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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Sets date in sql database correctly
            modelBuilder.Entity<Snippet>()
            .Property(f => f.DateCreated)
            .HasColumnType("datetime2");

            modelBuilder.Entity<Author>().HasData(
                new Author {
                    ID = 1,
                    Name = "Jeff"
                },
                new Author
                {
                    ID = 2,
                    Name = "Kendra"
                },
                new Author {
                    ID = 3,
                    Name = "Richard"
                },
                new Author
                {
                    ID = 4,
                    Name = "Allisa"
                },     
                new Author
                {
                    ID = 5,
                    Name = "Jeremy"
                }
            );

            

            modelBuilder.Entity<Snippet>().HasData(
                new 
                {
                    ID = 1,
                    Title = "Hello World console writeline",
                    DateCreated = DateTime.Now,
                    CodeBody = "Console.WriteLine(\"Hello World!\")",
                    Language = Language.Csharp,
                    Notes = "This is cool.",
                    AuthorID = 1
                },
                new 
                {
                    ID = 2,
                    Title = "Hello World python",
                    DateCreated = DateTime.Now,
                    CodeBody = "Print(\"Hello World!\")",
                    Language = Language.Python,
                    Notes = "This is cooler",
                    AuthorID = 2
                }
            );

        }

        public DbSet<Snippet> Snippets { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
