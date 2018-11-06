using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Reposit.Data;
using Reposit.Models;

namespace Reposit.Controllers
{
    public class FullSnippetsController : Controller
    {
        private readonly RepositDbContext _context;

        public FullSnippetsController(RepositDbContext context)
        {
            _context = context;
        }

        // GET: FullSnippets
        public async Task<IActionResult> Index()
        {
            var repositDbContext = _context.FullSnippet.Include(f => f.Category);
            return View(await repositDbContext.ToListAsync());
        }

        // GET: FullSnippets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fullSnippet = await _context.FullSnippet
                .Include(f => f.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fullSnippet == null)
            {
                return NotFound();
            }

            return View(fullSnippet);
        }

        // GET: FullSnippets/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "Title");
            return View();
        }

        // POST: FullSnippets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Date,CodeBody,Language,Notes,Author,CategoryID")] FullSnippet fullSnippet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fullSnippet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "Title", fullSnippet.CategoryID);
            return View(fullSnippet);
        }

        // GET: FullSnippets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fullSnippet = await _context.FullSnippet.FindAsync(id);
            if (fullSnippet == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "Title", fullSnippet.CategoryID);
            return View(fullSnippet);
        }

        // POST: FullSnippets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Date,CodeBody,Language,Notes,Author,CategoryID")] FullSnippet fullSnippet)
        {
            if (id != fullSnippet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fullSnippet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FullSnippetExists(fullSnippet.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "Title", fullSnippet.CategoryID);
            return View(fullSnippet);
        }

        // GET: FullSnippets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fullSnippet = await _context.FullSnippet
                .Include(f => f.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fullSnippet == null)
            {
                return NotFound();
            }

            return View(fullSnippet);
        }

        // POST: FullSnippets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fullSnippet = await _context.FullSnippet.FindAsync(id);
            _context.FullSnippet.Remove(fullSnippet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FullSnippetExists(int id)
        {
            return _context.FullSnippet.Any(e => e.ID == id);
        }
    }
}
