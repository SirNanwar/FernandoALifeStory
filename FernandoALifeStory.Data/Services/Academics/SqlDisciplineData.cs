using FernandoALifeStory.Data.Models.Academics;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FernandoALifeStory.Data.Services.Context;

namespace FernandoALifeStory.Data.Services.Academics
{
    public class SqlDisciplineData : IDisciplineData
    {
        private readonly DbSet<Discipline> disciplines;

        public SqlDisciplineData(FernandoDbContext db)
        {
            this.disciplines = db.Disciplines;
        }

        public IEnumerable<Discipline> GetAll()
        {
            return disciplines.OrderBy(x => x.Name);
        }

        public Discipline GetById(int id)
        {
            return disciplines.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Discipline> GetCurriculumByDegreeId(int id)
        {
            return disciplines.Where(x => x.DegreeId == id);
        }
    }
}
