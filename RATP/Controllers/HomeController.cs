using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RATP.Models;
using RATP.Helpers;

namespace RATP.Controllers
{
    public class HomeController : Controller
    {

        private readonly MvcRATPContext _context;

        private readonly DijkstraHelper _dijkstraHelper;

        public HomeController(MvcRATPContext context)
        {
            _context = context;
            _dijkstraHelper = new DijkstraHelper(context);
        }

        public IActionResult Index()
        {
            Station start = _context.Station.Where(s => s.Name == "Anvers").FirstOrDefault();
            Station end = _context.Station.Where(s => s.Name == "Sentier").FirstOrDefault();

            ViewData["path"] = _dijkstraHelper.shortest_path(start, end).AsEnumerable();

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
