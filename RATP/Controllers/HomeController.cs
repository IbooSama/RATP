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

        private readonly AStarHelper _aStarHelper;

        public HomeController(MvcRATPContext context)
        {
            _context = context;
            _dijkstraHelper = new DijkstraHelper();
            _aStarHelper = new AStarHelper();
        }

        public IActionResult Index()
        {
            List<Station> stations = _context.Station.ToList();

            ViewData["stations"] = JsonConvert.SerializeObject(stations);

            return View();
        }

        public IActionResult Result(ItineraryFormData formData)
        {
            List<Station> stations = _context.Station.ToList();

            Station start = stations.Where(s => s.Name == formData.DepartureTextBoxData).FirstOrDefault();
            Station end = stations.Where(s => s.Name == formData.ArrivalTextBoxData).FirstOrDefault();

            List<Station> cleanPath = cleanResult(_aStarHelper.shortest_path(start, end, stations));
            //List<Station> cleanPath = cleanResult(_dijkstraHelper.shortest_path(start, end, stations));

            ViewData["path"] = cleanPath.AsEnumerable();
            ViewData["jsonPath"] = JsonConvert.SerializeObject(cleanPath);

            return View();
        }

        public List<Station> cleanResult(List<Station> path)
        {
            int start = 0;
            while (path[start].Name == path[start + 1].Name) {
                start++;
            }

            for (int i = 0; i < start; i++) {
                path.Remove(path[i]);
            }

            return path;
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
