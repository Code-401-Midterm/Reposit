using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositAPI.Data;
using RepositAPI.Models;


namespace RepositAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnippetController : ControllerBase
    {
        private RepositDbContext _context;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="context">DB context</param>
        public SnippetController(RepositDbContext context)
        {
            _context = context;
        }

        
        /// <summary>
        /// Get all Snippets
        /// </summary>
        /// <returns>A list of all Snippets</returns>
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

        /// <summary>
        /// Gets and returns a Snippet by ID
        /// </summary>
        /// <param name="id">Snippet's ID</param>
        /// <returns>The requested Snippet</returns>
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

        /// <summary>
        /// Create a Snippet
        /// </summary>
        /// <param name="snippet">The snippet to create in the DB</param>
        /// <returns>201 status and new snippet's details</returns>
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