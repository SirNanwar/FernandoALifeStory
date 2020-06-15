using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.WorkExperiences;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public class SqlWorkData : IWorkData
    {
        private readonly DbSet<Work> workExperiences;

        public SqlWorkData(FernandoDbContext db)
        {
            this.workExperiences = db.Works;
        }

        public IEnumerable<Work> GetAll()
        {
            return workExperiences.OrderBy(x => x.StartDate);
        }

        public Work GetById(int id)
        {
            return workExperiences.FirstOrDefault(x => x.Id == id);
        }
    }
}