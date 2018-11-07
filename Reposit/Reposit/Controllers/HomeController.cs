using Microsoft.AspNetCore.Mvc;
using Reposit.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategory _context;

        public HomeController(ICategory context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetCategories());
        }

    }
}
