using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RATP.Models;

namespace RATP.Controllers
{
    public class LinesController : Controller
    {
        private readonly MvcLineContext _context;

        public LinesController(MvcLineContext context)
        {
            _context = context;
        }

        // GET: Lines
        public async Task<IActionResult> Index()
        {
            return View(await _context.Line.ToListAsync());
        }

    }
}
