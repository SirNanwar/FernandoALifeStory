using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FernandoALifeStory.Data.Models.Courses;

namespace FernandoALifeStory.Data.Services.Courses
{
    public class SqlCourseData : ICourseData
    {
        private readonly FernandoDbContext db;

        public SqlCourseData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.OrderBy(x => x.CourseName);
        }

        public Course GetById(int id)
        {
            return db.Courses.FirstOrDefault(x => x.Id == id);
        }
    }
}
