using System;
using System.Collections.Generic;

namespace RATP.Models
{
    public class Station
    {
        public int ID { get; set; }
        public string LineID { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Station()
        {
        }
    }
}
