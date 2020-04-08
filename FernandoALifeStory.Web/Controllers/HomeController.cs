using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FernandoALifeStory.Web.Models;
using FernandoALifeStory.Data.Services;

namespace FernandoALifeStory.Web.Controllers
{
    public class HomeController : Controller
    {
        ICourseData db;

        public HomeController()
        {
            db = new InMemoryCourseData();
        }

        public IActionResult Index()
        {
            var model = db.GetAll();

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
