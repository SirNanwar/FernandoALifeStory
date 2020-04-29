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
        private readonly ICertificationData certificationDB;

        public CertificationsController(ICertificationData certificationDB)
        {
            this.certificationDB = certificationDB;
        }

        public IActionResult Index()
        {
            var model = certificationDB.GetAll();
            return View(model);
        }
    }
}