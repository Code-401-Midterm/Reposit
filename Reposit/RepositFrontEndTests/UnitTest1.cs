using Microsoft.EntityFrameworkCore;
using Reposit.Data;
using Reposit.Models;
using System;
using Xunit;
using Reposit;
using System.Collections.Generic;

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
        /// Test to get full snippet title
        /// </summary>
        [Fact]
        public void TestToGetFullSnippetTitle()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.Title = "Test Title";

            Assert.Equal("Test Title", fullSnippet.Title);
        }

        /// <summary>
        /// Test to get full snippet code body
        /// </summary>
        [Fact]
        public void TestToGetFullSnippetCodeBody()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.CodeBody = "<h1>code</h1>";

            Assert.Equal("<h1>code</h1>", fullSnippet.CodeBody);
        }

        ///// <summary>
        ///// Test to get full snippet language
        ///// </summary>
        //[Fact]
        //public void TestToGetFullSnippetLanguage()
        //{
        //    FullSnippet fullSnippet = new FullSnippet();
        //    fullSnippet.Language = "C#";

        //    Assert.Equal("C#", fullSnippet.Language);
        //}

        /// <summary>
        /// Test to get full snippet notes
        /// </summary>
        [Fact]
        public void TestToGetFullSnippetNotes()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.Notes = "notes notes notes";

            Assert.Equal("notes notes notes", fullSnippet.Notes);
        }

        /// <summary>
        /// Test to get full snippet author
        /// </summary>
        [Fact]
        public void TestToGetFullSnippetAuthor()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.Author = "author";

            Assert.Equal("author", fullSnippet.Author);
        }

        /// <summary>
        /// Test to set full snippet title
        /// </summary>
        [Fact]
        public void TestToSetFullSnippetTitle()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.Title = "Test Title";

            fullSnippet.Title = "Test Title 2";

            Assert.Equal("Test Title 2", fullSnippet.Title);
        }

        /// <summary>
        /// Test to set full snippet code body
        /// </summary>
        [Fact]
        public void TestToSetFullSnippetCodeBody()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.CodeBody = "<h1>code</h1>";

            fullSnippet.CodeBody = "<h1>code 2</h1>";

            Assert.Equal("<h1>code 2</h1>", fullSnippet.CodeBody);
        }

        ///// <summary>
        ///// Test to set full snippet language
        ///// </summary>
        //[Fact]
        //public void TestToSetFullSnippetLanguage()
        //{
        //    FullSnippet fullSnippet = new FullSnippet();
        //    fullSnippet.Language = "C#";

        //    fullSnippet.Language = "JavaScript";

        //    Assert.Equal("JavaScript", fullSnippet.Language);
        //}

        /// <summary>
        /// Test to set full snippet notes
        /// </summary>
        [Fact]
        public void TestToSetFullSnippetNotes()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.Notes = "Notes go here";

            fullSnippet.Notes = "Notes notes notes";

            Assert.Equal("Notes notes notes", fullSnippet.Notes);
        }

        /// <summary>
        /// Test to set full snippet author
        /// </summary>
        [Fact]
        public void TestToSetFullSnippetAuthor()
        {
            FullSnippet fullSnippet = new FullSnippet();
            fullSnippet.Author = "Author";

            fullSnippet.Author = "Author Author";

            Assert.Equal("Author Author", fullSnippet.Author);
        }

        /// <summary>
        /// Testing to create and read a full snippet
        /// </summary>
        [Fact]
        public async void TestToCreateAndReadFullSnippet()
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

        /// <summary>
        /// Testing to update a full snippet
        /// </summary>
        [Fact]
        public async void TestToUpdateFullSnippet()
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

                snippet.Title = "Update Test";
                context.FullSnippet.Update(snippet);
                context.SaveChanges();

                var snippetName = await context.FullSnippet.FirstOrDefaultAsync(x => x.Title == snippet.Title);

                Assert.Equal("Update Test", snippetName.Title);
            }
        }

        /// <summary>
        /// Testing to delete a full snippet
        /// </summary>
        [Fact]
        public async void TestToDeleteFullSnippet()
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

                context.FullSnippet.Remove(snippet);
                context.SaveChanges();

                var snippetName = await context.FullSnippet.ToListAsync();

                Assert.DoesNotContain(snippet, snippetName);
            }
        }

        /// <summary>
        /// Testing to create and read a category
        /// </summary>
        [Fact]
        public async void TestToCreateAndReadCategory()
        {
            DbContextOptions<RepositDbContext> options =
                new DbContextOptionsBuilder<RepositDbContext>()
                .UseInMemoryDatabase("GetCategoryTitle")
                .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                Category category = new Category();
                category.Title = "Binary Tree";

                context.Category.Add(category);
                context.SaveChanges();

                var categoryTitle = await context.Category.FirstOrDefaultAsync(x => x.Title == category.Title);

                Assert.Equal("Binary Tree", categoryTitle.Title);
            }
        }

        /// <summary>
        /// Testing to update a category
        /// </summary>
        [Fact]
        public async void TestToUpdateCategory()
        {
            DbContextOptions<RepositDbContext> options =
                new DbContextOptionsBuilder<RepositDbContext>()
                .UseInMemoryDatabase("GetCategoryTitle")
                .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                Category category = new Category();
                category.Title = "Binary Tree";

                context.Category.Add(category);
                context.SaveChanges();

                category.Title = "Final Exam";

                context.Category.Update(category);
                context.SaveChanges();

                var categoryTitle = await context.Category.FirstOrDefaultAsync(x => x.Title == category.Title);

                Assert.Equal("Final Exam", categoryTitle.Title);
            }
        }

        /// <summary>
        /// Testing to delete a category
        /// </summary>
        [Fact]
        public async void TestToDeleteCategory()
        {
            DbContextOptions<RepositDbContext> options =
                new DbContextOptionsBuilder<RepositDbContext>()
                .UseInMemoryDatabase("GetCategoryTitle")
                .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                Category category = new Category();
                category.Title = "Binary Tree";

                context.Category.Add(category);
                context.SaveChanges();

                context.Category.Remove(category);
                context.SaveChanges();

                var categoryTitle = await context.Category.ToListAsync();

                Assert.DoesNotContain(category, categoryTitle);
            }
        }

        /// <summary>
        /// Test to get ViewModel AllSnippet list property
        /// </summary>
        [Fact]
        public void GetViewModelAllSnippetList()
        {
            ViewModel viewModel = new ViewModel();
            List<FullSnippet> list = new List<FullSnippet>();
            FullSnippet fs1 = new FullSnippet();
            FullSnippet fs2 = new FullSnippet();
            fs1.Title = "Nested Loops";
            fs2.Title = "Array Search";
            list.Add(fs1);
            list.Add(fs2);
            viewModel.AllSnippets = list;

            Assert.Contains(fs1, viewModel.AllSnippets);
        }

        /// <summary>
        /// Test to set ViewModel AllSnippet list property
        /// </summary>
        [Fact]
        public void SetViewModelAllSnippetList()
        {
            ViewModel viewModel = new ViewModel();
            List<FullSnippet> list = new List<FullSnippet>();
            FullSnippet fs1 = new FullSnippet();
            FullSnippet fs2 = new FullSnippet();
            fs1.Title = "Nested Loops";
            fs2.Title = "Array Search";
            list.Add(fs1);
            list.Add(fs2);
            viewModel.AllSnippets = list;

            viewModel.AllSnippets.Remove(fs2);
            Assert.DoesNotContain(fs2, list);
        }

        /// <summary>
        /// Test to get ViewModel category ID
        /// </summary>
        [Fact]
        public void GetViewModelCategoryID()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.CategoryID = 23;

            Assert.Equal(23, viewModel.CategoryID);
        }

        /// <summary>
        /// Test to set ViewModel category ID
        /// </summary>
        [Fact]
        public void SetViewModelCategoryID()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.CategoryID = 23;

            viewModel.CategoryID = 99;
            Assert.Equal(99, viewModel.CategoryID);
        }
    }
}