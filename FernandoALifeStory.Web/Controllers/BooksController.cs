using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Services.Books;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookData db;

        public BooksController(IBookData db)
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
            var model = db.GetById(id);

            if(model is null)
            {
                return View("NotFound");
            }

            return View(model);
        }
    }
}