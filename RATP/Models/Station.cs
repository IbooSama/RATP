using System;
namespace RATP.Models
{
    public class Station
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string LineID { get; set; }
        public int Number { get; set; }

        public Station()
        {
        }
    }
}