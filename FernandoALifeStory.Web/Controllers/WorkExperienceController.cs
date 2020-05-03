using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.WorkExperiences;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class WorkExperienceController : Controller
    {
        private readonly IWorkData workDB;
        private readonly IAchievementData achievementDB;

        public WorkExperienceController(IWorkData workDB,
                                        IAchievementData achievementDB)
        {
            this.workDB = workDB;
            this.achievementDB = achievementDB;
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
    }
}