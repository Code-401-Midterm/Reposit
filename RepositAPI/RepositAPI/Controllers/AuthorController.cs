﻿using System;
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

        /// <summary>
        /// Returns all Authors with their details
        /// </summary>
        /// <returns>A list of all Authors</returns>
        [HttpGet]
        public async Task<IEnumerable<AuthorDTO>> Get()
        {
            //return await _context.Authors.ToListAsync();
            var authors = _context.Authors
        }

        /// <summary>
        /// Gets an Author by ID
        /// </summary>
        /// <param name="id">Required</param>
        /// <returns>The Author's details and a list of all Snippets authored</returns>
        [HttpGet("{id}", Name = "GetAuthorByID")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            //var author = await _context.Authors.FirstOrDefaultAsync(x => x.ID == id);
            //var author = await _context.Authors
            //                   .Include(au => au.Snippets)
            //                   .FirstOrDefaultAsync(x => x.ID == id);

            var snippets =  _context.Snippets
                                 .Where(s => s.AuthorID == id)
                                 .Select(s => new SnippetDTO
                                 {
                                     ID = s.ID,
                                     Title = s.Title,
                                     DateCreated = s.Date,
                                     CodeBody = s.CodeBody,
                                     Language = s.Language,
                                     Notes = s.Notes,
                                     Author = s.Author.Name,
                                     AuthorID = s.AuthorID
                                 }).ToList();


            var author = await _context.Authors
                               .Select(a =>
                               new AuthorDTO
                               {
                                   ID = a.ID,
                                   Name = a.Name,
                                   Snippets = snippets

                               }).SingleOrDefaultAsync(au => au.ID == id);

            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        /// <summary>
        /// Createss a new Author
        /// </summary>
        /// <param name="author">Required. Do not include an explicit
        /// id in the body. Name field is required.</param>
        /// <returns>201 Created status and new Author's details</returns>
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