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
        public async Task<IEnumerable<Snippet>> Get()
        {
            return await _context.Snippets.ToListAsync();
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
                                    DateCreated = s.DateCreated,
                                    CodeBody = s.CodeBody,
                                    Language = s.Language,
                                    Notes = s.Notes,
                                    AuthorName = s.Author.Name,
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