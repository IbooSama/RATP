using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
               
namespace RATP.Models
{
    public class Line
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Directions { get; set; }
        public string Code { get; set; }

        public Line()
        {
        }
    }
}
