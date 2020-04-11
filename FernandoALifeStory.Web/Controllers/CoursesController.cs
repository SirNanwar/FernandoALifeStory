using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseData db;

        public CoursesController(ICourseData db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.GetById(id);

            if(model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }
    }
}