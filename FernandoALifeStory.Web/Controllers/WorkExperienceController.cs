using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.Skills;
using FernandoALifeStory.Data.Services.WorkExperiences;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class WorkExperienceController : Controller
    {
        private readonly IWorkData workDB;
        private readonly IAchievementData achievementDB;
        private readonly IWorkSkillData workSkillDB;
        private readonly ISkillData skillDB;

        public WorkExperienceController(IWorkData workDB,
                                        IAchievementData achievementDB,
                                        IWorkSkillData workSkillDB,
                                        ISkillData skillDB)
        {
            this.workDB = workDB;
            this.achievementDB = achievementDB;
            this.workSkillDB = workSkillDB;
            this.skillDB = skillDB;
        }

        public IActionResult Index()
        {
            var model = workDB.GetAll();

            if (model.Count() == 0)
            {
                return View("NoWork");
            }
            return View(model);
        }

        public IActionResult Achievements(int id)
        {
            var model = achievementDB.GetAchievementsByWorkId(id);

            if (model is null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        public IActionResult Skills(int id)
        {
            var model = from skills in skillDB.GetAll().OrderBy(x => x.Type)
                        join workSkill in workSkillDB.GetByWorkId(id).ToList() on skills.Id equals workSkill.SkillId
                        select skills;

            if (model is null)
            {
                return View("SkillNotFound");
            }

            return View(model);
        }
    }
}