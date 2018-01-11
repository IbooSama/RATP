using System;
namespace RATP.Models
{
    public class Line
    {
        private string name;

        private int id;

        private int code;

        private string directions;

        public Line(String name, int id, int code, string directions)
        {
            this.name = name;
            this.id = id;
            this.code = code;
            this.directions = directions;
        }
    }
}
