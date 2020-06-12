using FernandoALifeStory.Data.Models.WorkExperiences;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FernandoALifeStory.Data.Services.Context;

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
