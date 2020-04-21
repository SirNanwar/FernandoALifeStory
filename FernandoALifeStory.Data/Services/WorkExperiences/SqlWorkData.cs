using FernandoALifeStory.Data.Models.WorkExperiences;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public class SqlWorkData : IWorkData
    {
        private readonly FernandoDbContext db;

        public SqlWorkData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Work> GetAll()
        {
            return db.WorkExperiences.OrderBy(x => x.StartDate);
        }

        public Work GetById(int id)
        {
            return db.WorkExperiences.FirstOrDefault(x => x.Id == id);
        }
    }
}
