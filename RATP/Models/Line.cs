using System;
namespace RATP.Models
{
    public class Line
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Directions { get; set; }

        public Line()
        {
        }
    }
}