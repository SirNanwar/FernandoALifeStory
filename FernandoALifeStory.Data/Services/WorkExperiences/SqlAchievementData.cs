using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.WorkExperiences;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public class SqlAchievementData : IAchievementData
    {
        private readonly DbSet<Achievement> achievements;

        public SqlAchievementData(FernandoDbContext db)
        {
            this.achievements = db.Achievements;
        }

        public IEnumerable<Achievement> GetAll()
        {
            return achievements.OrderBy(x => x.Id);
        }

        public Achievement GetById(int id)
        {
            return achievements.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Achievement> GetAchievementsByWorkId(int id)
        {
            return achievements.Where(x => x.WorkId == id);
        }
    }
}