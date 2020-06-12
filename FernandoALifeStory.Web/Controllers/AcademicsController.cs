using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.Academics;
using FernandoALifeStory.Data.Services.Skills;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class AcademicsController : Controller
    {
        private readonly IDegreeData degreeDB;
        private readonly IDisciplineData disciplineDB;
        private readonly IProjectData projectDB;
        private readonly IDisciplineSkillData disciplineSkillDB;
        private readonly ISkillData skillDB;

        public AcademicsController(IDegreeData degreeDB,
                                   IDisciplineData disciplineDB,
                                   IProjectData projectDB,
                                   IDisciplineSkillData disciplineSkillDB,
                                   ISkillData skillDB)
        {
            this.degreeDB = degreeDB;
            this.disciplineDB = disciplineDB;
            this.projectDB = projectDB;
            this.disciplineSkillDB = disciplineSkillDB;
            this.skillDB = skillDB;
        }

        public IActionResult Index()
        {
            var model = degreeDB.GetAll();

            if (model.Count() == 0)
            {
                return View("NoDegrees");
            }
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

        public IActionResult Skills(int id)
        {
            var model = from skills in skillDB.GetAll().OrderBy(x => x.Type)
                        join disciplineSkill in disciplineSkillDB.GetByDisciplineId(id).ToList() on skills.Id equals disciplineSkill.SkillId
                        select skills;

            if (model is null)
            {
                return View("SkillNotFound");
            }

            return View(model);
        }
    }
}