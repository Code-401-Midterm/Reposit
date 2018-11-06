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
    public class AuthorController : ControllerBase
    {
        private RepositDbContext _context;
        public AuthorController(RepositDbContext context)
        {
            _context = context;
        }

        //Get All
        [HttpGet]
        public async Task<IEnumerable<Author>> Get()
        {
            return await _context.Authors.ToListAsync();
        }

        //Get Author by ID
        [HttpGet("{id}", Name = "GetAuthorByID")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            //var author = await _context.Authors.FirstOrDefaultAsync(x => x.ID == id);
            var author = await _context.Authors
                               .Include(au => au.Snippets)
                               .FirstOrDefaultAsync(x => x.ID == id);
            if(author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        //Create new Author
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return CreatedAtRoute("GetAuthorByID", new { id = author.ID }, author);
        }

    }
}