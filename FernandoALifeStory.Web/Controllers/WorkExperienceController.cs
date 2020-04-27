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
        private readonly IWorkData db;

        public WorkExperienceController(IWorkData db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = db.GetAchievementsByWorkId(id);

            if (model is null)
            {
                return View("NotFound");
            }

            return View(model);
        }
    }
}