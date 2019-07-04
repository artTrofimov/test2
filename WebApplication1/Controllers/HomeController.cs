using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Geoportal.Models;

namespace Geoportal.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        PointContext db = new PointContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Point> points = db.Points;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = points;
            // возвращаем представление
            return View();
        }
    }
}