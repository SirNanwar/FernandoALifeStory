using FernandoALifeStory.Data.Models.Academics;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Academics
{
    public class SqlDegreeData : IDegreeData
    {
        private readonly FernandoDbContext db;

        public SqlDegreeData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Degree> GetAll()
        {
            return db.Degrees.OrderBy(x => x.StartDate);
        }

        public Degree GetById(int id)
        {
            return db.Degrees.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Discipline> GetCurriculumByDegreeId(int id)
        {
            return db.Disciplines.Where(x => x.DegreeId == id);
        }

        public IEnumerable<Project> GetProjectByDisciplineId(int id)
        {
            return db.Projects.Where(x => x.DisciplineId == id);
        }
    }
}
