using System;
using Xunit;
using RepositAPI.Models;
using RepositAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TestAuthors
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests getters for Author model
        /// </summary>
        [Fact]
        public void AuthorCanGetTest()
        {
            Author author = new Author();
            author.Name = "El Champ";
            Assert.Equal("El Champ", author.Name);
        }

        /// <summary>
        /// Tests setters for Author model
        /// </summary>
        [Fact]
        public void AuthorCanSetTest()
        {
            Author author = new Author();
            author.Name = "El Champ";

            author.Name = "Pug";
            Assert.Equal("Pug", author.Name);
        }

        /// <summary>
        /// Tests that correct Author is saved in DB
        /// </summary>
        [Fact]
        public async void AuthorCanSaveAndGetAllTest()
        {
            DbContextOptions<RepositDbContext> options =
            new DbContextOptionsBuilder<RepositDbContext>()
            .UseInMemoryDatabase("AuthorCanSave")
            .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                //Arrange
                Author a = new Author();
                a.Name = "Pug";
                context.Authors.Add(a);
                Author b = new Author();
                b.Name = "Pugador";
                context.Authors.Add(b);
                Author c = new Author();
                c.Name = "Labradoodle";
                context.Authors.Add(c);

                context.SaveChanges();

                List<Author> testList = new List<Author>();
                testList.Add(a);
                testList.Add(b);
                testList.Add(c);

                //Act
                var authors = await context.Authors.ToArrayAsync();

                //Assert
                Assert.Equal(authors, testList);
            }
        }

        [Fact]
        public async void AuthorCanGetOneTest()
        {
            DbContextOptions<RepositDbContext> options =
            new DbContextOptionsBuilder<RepositDbContext>()
            .UseInMemoryDatabase("AuthorCanGet")
            .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                //Arrange
                Author a = new Author();
                a.Name = "Pug";
                context.Authors.Add(a);
                Author b = new Author();
                b.Name = "Pugador";
                context.Authors.Add(b);
                Author c = new Author();
                c.Name = "Labradoodle";
                context.Authors.Add(c);

                context.SaveChanges();

                //Act
                var author = await context.Authors.FirstOrDefaultAsync(x => x.Name == a.Name);

                //Assert
                Assert.Equal(author.ID, a.ID);
            }
        }
    }
}
