using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Services.Certifications;
using FernandoALifeStory.Data.Services.Skills;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class CertificationsController : Controller
    {
        private readonly ICertificationData certificationDB;
        private readonly ICertificationSkillData certificationSkillDB;
        private readonly ISkillData skillDB;

        public CertificationsController(ICertificationData certificationDB,
                                        ICertificationSkillData certificationSkillDB,
                                        ISkillData skillDB)
        {
            this.certificationDB = certificationDB;
            this.certificationSkillDB = certificationSkillDB;
            this.skillDB = skillDB;
        }

        public IActionResult Index()
        {
            IEnumerable<Certification> model = certificationDB.GetAll();

            if (model.Count() == 0)
            {
                return View("NoCertifications");
            }
            return View(model);
        }

        public IActionResult Skills(int id)
        {
            var model = from skills in skillDB.GetAll().OrderBy(x => x.Type)
                        join certificationSkill in certificationSkillDB.GetByCertificationId(id).ToList() on skills.Id equals certificationSkill.SkillId
                        select skills;

            if (model is null)
            {
                return View("SkillNotFound");
            }

            return View(model);
        }
    }
}