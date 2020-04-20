using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FernandoALifeStory.Data.Models;

namespace FernandoALifeStory.Data.Services
{
    public class SqlCourseData : ICourseData
    {
        private readonly CourseDbContext db;

        public SqlCourseData(CourseDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses;
        }

        public Course GetById(int id)
        {
            return db.Courses.FirstOrDefault(r => r.Id == id);
        }
    }
}
