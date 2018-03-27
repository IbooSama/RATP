using System;
using RATP.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RATP.Helpers
{
    public class AStarHelper
    {
        
        public List<Station> shortest_path(Station start, Station finish, List<Station> stations)
        {
            Dictionary<Station, List<Station>> mappedStations = mapConnections(stations);

            // Station => Station
            Dictionary<Station, Station> previous = new Dictionary<Station, Station>();
            // Station => distance
            Dictionary<Station, int> distances = new Dictionary<Station, int>();
            // Station => distanceToEnd
            Dictionary<Station, double> straightDistancesToEnd = getStationsStraightDistancesToEnd(stations, finish);
            // [Station, Station, Station, Station...]
            List<Station> nodes = new List<Station>();
            // [Station, Station, Station, Station...]
            List<Station> path = null;

            // Add all vertices (summits or stations) to the List nodes
            // Initialize distances to +infinites except for the start vertex
            foreach (var vertex in mappedStations.Keys)
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
                nodes = nodes.OrderBy(x => distances[x] + straightDistancesToEnd[x]).ToList();

                var smallest = nodes[0];

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
                    break;
                }

                Station smallestStation = mappedStations.Keys.Where(s => (s.ID == smallest.ID)).FirstOrDefault();
                List<Station> neighbors = mappedStations[smallestStation];

                // Update the weighs depending on the connections
                foreach (var neighbor in neighbors)
                {
                    Station neighborStation = mappedStations.Keys.Where(s => (s.ID == neighbor.ID)).FirstOrDefault();

                    int neighborWeigh = 1;
                    if (neighborStation.LineID != smallestStation.LineID)
                    {
                        neighborWeigh = 10;
                    }

                    var alt = distances[smallest] + neighborWeigh;
                    if (alt < distances[neighbor])
                    {
                        distances[neighbor] = alt;
                        previous[neighbor] = smallest;
                    }
                }
            }

            path.Add(start);

            path.Reverse();

            return path;
        }

        private Dictionary<Station, double> getStationsStraightDistancesToEnd(List<Station> stations, Station end)
        {
            Dictionary<Station, double> distances = new Dictionary<Station, double>();
            foreach (var station in stations) {
                double distance = Math.Sqrt(Math.Pow((end.Longitude - station.Longitude), 2) + Math.Pow((end.Latitude - station.Latitude), 2));
                distances[station] = distance;
            }

            return distances;
        }

        private Dictionary<Station, List<Station>> mapConnections(List<Station> stations)
        {
            Dictionary<Station, List<Station>> mappedStations = new Dictionary<Station, List<Station>>();

            foreach (var station in stations)
            {
                mappedStations[station] = getConnections(station, stations);
            }

            return mappedStations;
        }

        private List<Station> getConnections(Station station, List<Station> stations)
        {
            List<Station> connections = new List<Station>();

            Station previous = stations.Where(s => (s.Number == (station.Number - 1) && s.LineID == station.LineID)).FirstOrDefault();
            if (previous != null)
            {
                connections.Add(previous);
            }

            Station next = stations.Where(s => (s.Number == (station.Number + 1) && s.LineID == station.LineID)).FirstOrDefault();
            if (next != null)
            {
                connections.Add(next);
            }

            foreach (var correspondance in stations.Where(s => s.Name == station.Name && s.LineID != station.LineID))
            {
                Station correspStation = stations.Where(s => s.ID == correspondance.ID).FirstOrDefault();
                if (correspStation != null)
                {
                    connections.Add(correspStation);
                }
            }
            return connections;
        }

    }
}
