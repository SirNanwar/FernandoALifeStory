using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoALifeStory.Data.Models;
using FernandoALifeStory.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FernandoALifeStory.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseData db;

        public CoursesController(ICourseData db)
        {
            this.db = db;
        }

        public IEnumerable<Course> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}