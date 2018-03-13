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
    public class StationsController : Controller
    {
        private readonly MvcRATPContext _context;

        public StationsController(MvcRATPContext context)
        {
            _context = context;
        }

        // GET: Stations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Station.ToListAsync());
        }

        private bool StationExists(int id)
        {
            return _context.Station.Any(e => e.ID == id);
        }
    }
}
