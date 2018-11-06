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
        [Fact]
        public void AuthorCanGetAndSetTest()
        {
            Author author = new Author();
            author.Name = "El Champ";
            Assert.Equal("El Champ", author.Name);

            author.Name = "Pug";
            Assert.Equal("Pug", author.Name);
        }

        [Fact]
        public async void AuthorCRUDTest()
        {
            DbContextOptions<RepositDbContext> options =
            new DbContextOptionsBuilder<RepositDbContext>()
            .UseInMemoryDatabase("AuthorCRUD")
            .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                //Arrange
                Author a = new Author();
                a.Name = "Pug";
                context.Authors.Add(a);
                context.SaveChanges();

                //Act
                var author = await context.Authors.FirstOrDefaultAsync(x => x.Name == a.Name);

                //Assert
                Assert.Equal(a.Name, author.Name);
                Assert.Equal(a.ID, author.ID);
            }
        }
    }
}
