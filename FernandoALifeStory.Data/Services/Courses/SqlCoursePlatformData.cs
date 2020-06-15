using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.Courses;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Services.Courses
{
    public class SqlCoursePlatformData : ICoursePlatformData
    {
        private readonly DbSet<CoursePlatform> coursePlatforms;

        public SqlCoursePlatformData(FernandoDbContext db)
        {
            this.coursePlatforms = db.CoursePlatforms;
        }

        public IEnumerable<CoursePlatform> GetAll()
        {
            return coursePlatforms.OrderBy(x => x.Name);
        }

        public CoursePlatform GetById(int id)
        {
            return coursePlatforms.FirstOrDefault(x => x.Id == id);
        }
    }
}