using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geoportal.Models
{
    public class Point
    {
        //ID точки
        public int Id { get; set; }
        //название точки
        public string Name { get; set; }
        // Координата X точки
        public double Coord_X { get; set; }
        // Координата Y точки
        public double Coord_Y { get; set; }
        public string Info { get; set; }
    }
}