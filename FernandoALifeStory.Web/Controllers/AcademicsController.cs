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
        private readonly IDegreeData degreeDB;
        private readonly IDisciplineData disciplineDB;
        private readonly IProjectData projectDB;

        public AcademicsController(IDegreeData degreeDB,
                                   IDisciplineData disciplineDB,
                                   IProjectData projectDB)
        {
            this.degreeDB = degreeDB;
            this.disciplineDB = disciplineDB;
            this.projectDB = projectDB;
        }

        public IActionResult Index()
        {
            var model = degreeDB.GetAll();
            return View(model);
        }

        public IActionResult Curriculum(int id)
        {
            var model = disciplineDB.GetCurriculumByDegreeId(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        public IActionResult Project(int id)
        {
            var model = projectDB.GetProjectsByDisciplineId(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }
    }
}