using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.Courses;
using Microsoft.EntityFrameworkCore;

namespace FernandoALifeStory.Data.Services.Courses
{
    public class SqlCourseData : ICourseData
    {
        private readonly DbSet<Course> courses;

        public SqlCourseData(FernandoDbContext db)
        {
            this.courses = db.Courses;
        }

        public IEnumerable<Course> GetAll()
        {
            return courses.OrderBy(x => x.CourseName);
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Course> GetCoursesByPlatformId(int id)
        {
            return courses.Where(x => x.CoursePlatformId == id);
        }
    }
}
