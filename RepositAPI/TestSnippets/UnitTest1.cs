using System;
using Xunit;
using RepositAPI.Models;
using RepositAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TestSnippets
{
    public class UnitTest1
    {
        //Test GetSnippetTitle
        [Fact]
        public void GetSnippetTitle()
        {
            Snippet s = new Snippet();
            s.Title = "Hello World";
            Assert.Equal("Hello World", s.Title);
        }

        //Test SetSnippetTitle
        [Fact]
        public void SetSnippetTitle()
        {
            Snippet s = new Snippet();
            s.Title = "test";
            s.Title = "Hello";
            Assert.Equal("Hello", s.Title);
        }

        //Test GetSnippetCodeBody
        [Fact]
        public void GetSnippetCodeBody()
        {
            Snippet s = new Snippet();
            s.CodeBody = "print('Hello World')";
            Assert.Equal("print('Hello World')", s.CodeBody);
        }

        //Test SetSnippetCodeBody
        [Fact]
        public void SetSnippetCodeBody()
        {
            Snippet s = new Snippet();
            s.CodeBody = "console.log('Hello world!')";
            s.CodeBody = "print('Hello World')";
            Assert.Equal("print('Hello World')", s.CodeBody);
        }

        //Test GetSetSnippetLanguage
        [Fact]
        public void GetSetSnippetLanguage()
        {
            Snippet s = new Snippet();
            s.Language = Language.Python;
            Assert.Equal(Language.Python, s.Language);
        }

        //Test GetSetSnippetNotes
        [Fact]
        public void GetSetSnippetNotes()
        {
            Snippet s = new Snippet();
            s.Notes = "notes notes notes";
            Assert.Equal("notes notes notes", s.Notes);
        }

        //Test GetSetSnippetAuthorID
        [Fact]
        public void GetSetSnippetAuthorID()
        {
            Snippet s = new Snippet();
            s.AuthorID = 1;
            Assert.Equal(1, s.AuthorID);
        }

        //Test Create and Get Snippet by ID
        [Fact]
        public async void CreateGetSnippetByID()
        {
            DbContextOptions<RepositDbContext> options =
            new DbContextOptionsBuilder<RepositDbContext>()
            .UseInMemoryDatabase("CreateGetSnippetByID")
            .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                //Arrange
                Snippet s = new Snippet();
                s.Title = "Test";
                s.CodeBody = "code stuff";
                s.Language = Language.Other;
                s.Notes = "notes";
                s.AuthorID = 1;
                context.Snippets.Add(s);
                context.SaveChanges();

                //Act
                var snippet = await context.Snippets.FirstOrDefaultAsync(x => x.Title == s.Title);

                //Assert
                Assert.Equal(s.Title, snippet.Title);
            }
        }


        //Test Get all snippets
        [Fact]
        public async void GetAllSnippets()
        {
            DbContextOptions<RepositDbContext> options =
            new DbContextOptionsBuilder<RepositDbContext>()
            .UseInMemoryDatabase("GetAllSnippets")
            .Options;

            using (RepositDbContext context = new RepositDbContext(options))
            {
                //Arrange
                Snippet s1 = new Snippet();
                s1.Title = "Test1";
                s1.CodeBody = "code stuff";
                s1.Language = Language.Other;
                s1.Notes = "notes";
                s1.AuthorID = 1;

                Snippet s2 = new Snippet();
                s2.Title = "Test2";
                s2.CodeBody = "code";
                s2.Language = Language.Other;
                s2.Notes = "notes2";
                s2.AuthorID = 1;

                Snippet s3 = new Snippet();
                s3.Title = "Test3";
                s3.CodeBody = "stuff";
                s3.Language = Language.Other;
                s3.Notes = "notes 3";
                s3.AuthorID = 1;

                context.Snippets.Add(s1);
                context.Snippets.Add(s2);
                context.Snippets.Add(s3);
                context.SaveChanges();

                List<Snippet> rawSnippets = new List<Snippet>();
                rawSnippets.Add(s1);
                rawSnippets.Add(s2);
                rawSnippets.Add(s3);


                //Act
                List<Snippet> snippets = await context.Snippets.ToListAsync();

                //Assert
                Assert.Equal(rawSnippets, snippets);
            }
        }

    }
}
