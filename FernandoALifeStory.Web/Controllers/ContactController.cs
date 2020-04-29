using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.Infos;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly INfoData infoDB;

        public ContactController(INfoData infoDB)
        {
            this.infoDB = infoDB;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}