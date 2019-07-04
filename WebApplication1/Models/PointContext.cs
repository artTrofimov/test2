using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace Geoportal.Models
{
    public class PointContext : DbContext
    {
        public DbSet<Point> Points { get; set; }
    }
}