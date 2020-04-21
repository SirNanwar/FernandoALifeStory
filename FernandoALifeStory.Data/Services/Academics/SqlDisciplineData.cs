using FernandoALifeStory.Data.Models.Academics;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Academics
{
    public class SqlDisciplineData : IDisciplineData
    {
        private readonly FernandoDbContext db;

        public SqlDisciplineData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Discipline> GetAll()
        {
            return db.Disciplines.OrderBy(x => x.Name);
        }

        public Discipline GetById(int id)
        {
            return db.Disciplines.FirstOrDefault(x => x.Id == id);
        }
    }
}
