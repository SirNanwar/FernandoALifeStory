using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.Academics;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class AcademicsController : Controller
    {
        private readonly IDegreeData db;

        public AcademicsController(IDegreeData db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public IActionResult Curriculum(int id)
        {
            var model = db.GetCurriculumByDegreeId(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        public IActionResult Project(int id)
        {
            var model = db.GetProjectByDisciplineId(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }
    }
}