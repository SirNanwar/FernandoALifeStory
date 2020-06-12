using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.Books;
using FernandoALifeStory.Data.Services.Skills;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookData bookDB;
        private readonly IBookSkillData bookSkillDB;
        private readonly ISkillData skillDB;

        public BooksController(IBookData bookDB,
                               IBookSkillData bookSkillDB,
                               ISkillData skillDB)
        {
            this.bookDB = bookDB;
            this.bookSkillDB = bookSkillDB;
            this.skillDB = skillDB;
        }

        public IActionResult Index()
        {
            var model = bookDB.GetAll();

            if (model.Count() == 0)
            {
                return View("NoBooks");
            }
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = bookDB.GetById(id);

            if(model is null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        public IActionResult Skills(int id)
        {
            var model = from skills in skillDB.GetAll()
                        join bookSkill in bookSkillDB.GetByBookId(id).ToList() on skills.Id equals bookSkill.SkillId
                        select skills;

            if (model is null)
            {
                return View("SkillNotFound");
            }

            return View(model);
        }
    }
}