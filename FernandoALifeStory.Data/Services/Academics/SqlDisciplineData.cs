using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.Academics;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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