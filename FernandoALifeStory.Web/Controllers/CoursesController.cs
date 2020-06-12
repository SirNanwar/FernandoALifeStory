using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using FernandoALifeStory.Data.Services.Courses;
using FernandoALifeStory.Data.Services.Skills;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICoursePlatformData platformDB;
        private readonly ICourseData courseDB;
        private readonly ICourseSkillData courseSkillDB;
        private readonly ISkillData skillDB;

        public CoursesController(ICoursePlatformData platformDB,
                                 ICourseData courseDB,
                                 ICourseSkillData courseSkillDB,
                                 ISkillData skillDB)
        {
            this.platformDB = platformDB;
            this.courseDB = courseDB;
            this.courseSkillDB = courseSkillDB;
            this.skillDB = skillDB;
        }

        public IActionResult Index()
        {
            var model = platformDB.GetAll();

            if(model.Count() == 0)
            {
                return View("NoCourse");
            }
            return View(model);
        }

        public IActionResult Courses(int id)
        {
            var model = courseDB.GetCoursesByPlatformId(id);

            if(model is null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = courseDB.GetById(id);

            if (model is null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        public IActionResult Skills(int id)
        {
            var model = from skills in skillDB.GetAll()
                        join courseSkill in courseSkillDB.GetByCourseId(id).ToList() on skills.Id equals courseSkill.SkillId
                        select skills;

            if (model is null)
            {
                return View("SkillNotFound");
            }

            return View(model);
        }
    }
}