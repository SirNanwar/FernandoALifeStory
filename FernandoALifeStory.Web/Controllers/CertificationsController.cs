using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.Certifications;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class CertificationsController : Controller
    {
        private readonly ICertificationData db;

        public CertificationsController(ICertificationData db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}