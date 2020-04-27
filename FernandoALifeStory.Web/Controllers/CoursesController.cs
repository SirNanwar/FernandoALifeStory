using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.Courses;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICoursePlatformData platformDB;
        private readonly ICourseData courseDB;

        public ICourseData CourseDB => courseDB;

        public CoursesController(ICoursePlatformData platformDB,
                                 ICourseData courseDB)
        {
            this.platformDB = platformDB;
            this.courseDB = courseDB;
        }

        public IActionResult Index()
        {
            var model = platformDB.GetAll();
            return View(model);
        }

        public IActionResult Courses(int id)
        {
            var model = platformDB.GetCoursesByPlatformId(id);

            if(model is null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = CourseDB.GetById(id);

            if (model is null)
            {
                return View("NotFound");
            }

            return View(model);
        }
    }
}