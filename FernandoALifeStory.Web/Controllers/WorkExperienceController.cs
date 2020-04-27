using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class WorkExperienceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}