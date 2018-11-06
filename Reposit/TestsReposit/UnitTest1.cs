using Microsoft.EntityFrameworkCore;
using Reposit.Data;
using Reposit.Models;
using System;
using Xunit;

namespace TestsReposit
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to get a category title
        /// </summary>
        [Fact]
        public void TestToGetCategoryModelProperty()
        {
            Category category = new Category();
            category.Title = "Test Title";

            Assert.Equal("Test Title", category.Title);
        }

        /// <summary>
        /// Test to set a category title
        /// </summary>
        [Fact]
        public void TestToSetCategoryModelProperty()
        {
            Category category = new Category();
            category.Title = "Test Title";

            category.Title = "Test Title 2";

            Assert.Equal("Test Title 2", category.Title);
        }

        /// <summary>
        /// Test to get full snippet properties
        /// </summary>
        [Fact]
        public void TestToGetFullSnippetProperties()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.Title = "Test Title";
            fullSnippet.CodeBody = "<h1>code</h1>";
            fullSnippet.Language = "C#";
            fullSnippet.Notes = "Notes go here";
            fullSnippet.Author = "Author";

            Assert.Equal("Test Title", fullSnippet.Title);
            Assert.Equal("<h1>code</h1>", fullSnippet.CodeBody);
            Assert.Equal("C#", fullSnippet.Language);
            Assert.Equal("Notes go here", fullSnippet.Notes);
            Assert.Equal("Author", fullSnippet.Author);
        }

        /// <summary>
        /// Test to set full snippet properties
        /// </summary>
        [Fact]
        public void TestToSetFullSnippetProperties()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.Title = "Test Title";
            fullSnippet.CodeBody = "<h1>code</h1>";
            fullSnippet.Language = "C#";
            fullSnippet.Notes = "Notes go here";
            fullSnippet.Author = "Author";

            fullSnippet.Title = "Test Title 2";
            fullSnippet.CodeBody = "<h1>code 2</h1>";
            fullSnippet.Language = "JavaScript";
            fullSnippet.Notes = "Notes notes notes";
            fullSnippet.Author = "Author Author";

            Assert.Equal("Test Title 2", fullSnippet.Title);
            Assert.Equal("<h1>code 2</h1>", fullSnippet.CodeBody);
            Assert.Equal("JavaScript", fullSnippet.Language);
            Assert.Equal("Notes notes notes", fullSnippet.Notes);
            Assert.Equal("Author Author", fullSnippet.Author);
        }

        [Fact]
        public async void TestToCreateCategory()
        {
            DbContextOptions<RepositDbContext> options =
                new DbContextOptionsBuilder<RepositDbContext>()
                .UseInMemoryDatabase("GetSnippetTitle")
                .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                FullSnippet snippet = new FullSnippet();
                snippet.Title = "Test";

                context.FullSnippet.Add(snippet);
                context.SaveChanges();

                var snippetName = await context.FullSnippet.FirstOrDefaultAsync(x => x.Title == snippet.Title);

                Assert.Equal("Test", snippetName.Title);
            }
        }


    }
}