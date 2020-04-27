using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using FernandoALifeStory.Data.Models.Courses;
using System.Text.RegularExpressions;

namespace FernandoALifeStory.Data.Services.Courses
{
    public class SqlCoursePlatformData : ICoursePlatformData
    {
        private readonly FernandoDbContext db;

        public SqlCoursePlatformData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CoursePlatform> GetAll()
        {
            return db.CoursePlatorms.OrderBy(x => x.Name);
        }

        public CoursePlatform GetById(int id)
        {
            return db.CoursePlatorms.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Course> GetCoursesByPlatformId(int id)
        {
            return db.Courses.Where(x => x.CoursePlatformId == id);
        }
    }
}
