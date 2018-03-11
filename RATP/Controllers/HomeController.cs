using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RATP.Models;

namespace RATP.Controllers
{
    public class HomeController : Controller
    {

        private readonly MvcLineContext _context;

        public HomeController(MvcLineContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Station start = _context.Station.Where(s => s.Name == "Abbesses").FirstOrDefault();
            Station end = _context.Station.Where(s => s.Name == "Chatillon Montrouge").FirstOrDefault();

            ViewData["shortest_path"] = shortest_path(start, end);

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<Station> shortest_path(Station departure, Station arrival)
        {
            var previous = new Dictionary<string, string>();
            var distances = new Dictionary<string, int>();
            var nodes = new List<string>();

            //List<int> path = null;
            List<Station> path = null;

            foreach (var vertex in _context.Station.AsEnumerable())
            {
                if (vertex.Name == departure.Name)
                {
                    distances[vertex.Name] = 0;
                }
                else
                {
                    distances[vertex.Name] = int.MaxValue;
                }

                nodes.Add(vertex.Name);
            }

            while (nodes.Count != 0)
            {
                nodes.Sort((x, y) => distances[x] - distances[y]);

                var smallest = nodes[0];
                nodes.Remove(smallest);

                if (smallest == arrival.Name)
                {
                    path = new List<Station>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(arrival);
                        smallest = previous[smallest];
                    }

                    break;
                }

                if (distances[smallest] == int.MaxValue)
                {
                    break;
                }

                Station current = _context.Station.Where(s => s.Name == smallest).FirstOrDefault();
                List<Station> connections = getConnections(current);

                foreach (var neighbor in connections)
                {
                    //int weigh = neighbor.Value;

                    // Set weigh to 1 by default, 3 if you need to change line
                    int weigh = 1;
                    if (neighbor.LineID != current.LineID) {
                        weigh = 3;
                    }
                    var alt = distances[smallest] + weigh;


                    if (alt < distances[neighbor.Name])
                    {
                        distances[neighbor.Name] = (int)alt;
                        previous[neighbor.Name] = smallest;
                    }
                }
            }
            path.Add(departure);

            return path;
        }

        private List<Station> getConnections(Station station)
        {
            List<Station> connections = new List<Station>();

            connections.Add(_context.Station.Where(s => s.Number == (station.Number - 1)).SingleOrDefault());
            connections.Add(_context.Station.Where(s => s.Number == (station.Number + 1)).SingleOrDefault());

            foreach(var correspondance in _context.Station.Where(s => s.Name == station.Name && s.LineID != station.LineID))
            {
                connections.Add(_context.Station.Where(s => s.Number == (correspondance.Number - 1)).SingleOrDefault());
                connections.Add(_context.Station.Where(s => s.Number == (correspondance.Number + 1)).SingleOrDefault());
            }

            return connections;
        }

    }
}
