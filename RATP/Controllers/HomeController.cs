using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RATP.Models;
using RATP.Helpers;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

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
            List<Station> stations = _context.Station.ToList();

            ViewData["stations"] = JsonConvert.SerializeObject(stations);

            return View();
        }

        public IActionResult Result(ItineraryFormData formData)
        {
            Station start = _context.Station.Where(s => s.Name == formData.DepartureTextBoxData).FirstOrDefault();
            Station end = _context.Station.Where(s => s.Name == formData.ArrivalTextBoxData).FirstOrDefault();

            ViewData["path"] = _dijkstraHelper.shortest_path(start, end).AsEnumerable();

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
