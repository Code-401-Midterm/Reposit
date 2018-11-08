using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositAPI.Data;
using RepositAPI.Models;
using RepositAPI.Models.ViewModels;

namespace RepositAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnippetController : ControllerBase
    {
        private RepositDbContext _context;
        public SnippetController(RepositDbContext context)
        {
            _context = context;
        }

        //Get All
        [HttpGet]
        public async Task<IEnumerable<SnippetDTO>> Get()
        {
            var snipList = await _context.Snippets.Include(s => s.Author).ToListAsync();
            var retList = new List<SnippetDTO>();
            foreach (var snippet in snipList)
            {
                retList.Add(
                    new SnippetDTO
                    {
                        ID = snippet.ID,
                        Title = snippet.Title,
                        DateCreated = snippet.Date,
                        CodeBody = snippet.CodeBody,
                        Language = snippet.Language.ToString(),
                        Notes = snippet.Notes,
                        Author = snippet.Author.Name,
                        AuthorID = snippet.AuthorID
                    }
                    );
            }
            return retList.ToList();
            //return await _context.Snippets.Include(s => s.Author).ToListAsync();
        }

        //Get Snippet by ID
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var snippet = await _context.Snippets
                                .Include(s => s.Author)
                                .Select(s =>
                                new SnippetDTO
                                {
                                    ID = s.ID,
                                    Title = s.Title,
                                    DateCreated = s.Date,
                                    CodeBody = s.CodeBody,
                                    Language = s.Language.ToString(),
                                    Notes = s.Notes,
                                    Author = s.Author.Name,
                                    AuthorID = s.AuthorID
                                }).SingleOrDefaultAsync(s => s.ID == id);

            if (snippet == null)
            {
                return NotFound();
            }

            return Ok(snippet);
        }

        //Create new Snippet
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Snippet snippet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.Snippets.AddAsync(snippet);
            await _context.SaveChangesAsync();
            return CreatedAtRoute("GetSnippetByID", new { id = snippet.ID }, snippet);
        }
    }
}