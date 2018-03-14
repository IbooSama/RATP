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

        private readonly MvcRATPContext _context;

        public HomeController(MvcRATPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Station start = _context.Station.Where(s => s.Name == "Anvers").FirstOrDefault();
            Station end = _context.Station.Where(s => s.Name == "Sentier").FirstOrDefault();

            ViewData["path"] = shortest_path(start, end).AsEnumerable();

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Station> shortest_path(Station start, Station finish)
        {
            // id => [id, id, id...]
            var previous = new Dictionary<Station, Station>();
            // id => [distance, distance, distance...]
            var distances = new Dictionary<Station, int>();
            // [id, id, id, id...]
            var nodes = new List<Station>();

            // [id, id, id, id...]
            List<Station> path = null;

            List<Station> vertices = _context.Station.ToList();

            // Add all vertices (summits or stations) to the List nodes
            // Initialize distances to +infinites except for the start vertex
            foreach (var vertex in vertices)
            {
                if (vertex == start)
                {
                    distances[vertex] = 0;
                }
                else
                {
                    distances[vertex] = int.MaxValue;
                }

                nodes.Add(vertex);
            }
            Console.WriteLine(nodes.Count + " stations were indexed.");

            // We unstack vertices one by one
            while (nodes.Count != 0)
            {
                nodes.Sort((x, y) => distances[x] - distances[y]);

                var smallest = nodes[0];
                Console.WriteLine("Processing station : " + smallest.Name);
                nodes.Remove(smallest);

                // Once we reached the end station, we store the smallest values and its previous stations in the path variable.
                if (smallest.Name == finish.Name)
                {
                    path = new List<Station>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest);
                        smallest = previous[smallest];
                    }
                    break;
                }

                if (distances[smallest] == int.MaxValue)
                {
                    Console.WriteLine("Breaking at : " + smallest.Name);
                    break;
                }

                Station smallestStation = _context.Station.Where(s => (s.ID == smallest.ID)).FirstOrDefault();
                List<Station> neighbors = getConnections(smallestStation);

                // Update the weighs depending on the connections
                foreach (var neighbor in neighbors)
                {
                    Station neighborStation = _context.Station.Where(s => (s.ID == neighbor.ID)).FirstOrDefault();

                    int neighborWeigh = 1;
                /*    if (neighborStation.LineID != smallestStation.LineID) {
                        neighborWeigh = 3;
                    }*/

                    var alt = distances[smallest] + neighborWeigh;
                    if (alt < distances[neighbor])
                    {
                        distances[neighbor] = alt;
                        previous[neighbor] = smallest;
                    }
                }
            }

            path.Add(start);

            return path;
        }

        private List<Station> getConnections(Station station)
        {
            List<Station> connections = new List<Station>();

            Station previous = _context.Station.Where(s => (s.Number == (station.Number - 1) && s.LineID == station.LineID)).FirstOrDefault();
            if (previous != null) {
                connections.Add(previous);
            }

            Station next = _context.Station.Where(s => (s.Number == (station.Number + 1) && s.LineID == station.LineID)).FirstOrDefault();
            if (next != null)
            {
                connections.Add(next);
            }

            foreach (var correspondance in _context.Station.Where(s => s.Name == station.Name && s.LineID != station.LineID))
            {
                Station correspStation = _context.Station.Where(s => s.ID == correspondance.ID).FirstOrDefault();
                if (correspStation != null) {
                    connections.Add(correspStation);
                }
            }
            Console.WriteLine(station.Name + " has as connections : ");
            foreach (var connection in connections) {
                Console.WriteLine(" - " + connection.Name);
            }
            return connections;
        }
    }
}
