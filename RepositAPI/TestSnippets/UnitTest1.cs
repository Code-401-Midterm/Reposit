using System;
using Xunit;
using RepositAPI.Models;

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

        //Test GetSetSnippetDate
        [Fact]
        public void GetSetSnippetDate()
        {
            Snippet s = new Snippet();
            DateTime dt = DateTime.Now;
            s.DateCreated = dt;
            Assert.Equal(dt, s.DateCreated);
        }

        //Test GetSetSnippetCodeBody
        [Fact]
        public void GetSetSnippetCodeBody()
        {
            Snippet s = new Snippet();
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
    }
}
