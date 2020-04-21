using FernandoALifeStory.Data.Models.WorkExperiences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public class SqlAchievementData : IAchievementData
    {
        private readonly FernandoDbContext db;

        public SqlAchievementData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Achievement> GetAll()
        {
            return db.Achievements.OrderBy(x => x.Id);
        }

        public Achievement GetById(int id)
        {
            return db.Achievements.FirstOrDefault(x => x.Id == id);
        }
    }
}
