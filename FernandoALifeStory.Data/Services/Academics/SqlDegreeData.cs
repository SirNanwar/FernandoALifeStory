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

        public IEnumerable<Degree> GetlAll()
        {
            return db.Degrees.OrderBy(x => x.StartDate);
        }

        public Degree GetById(int id)
        {
            return db.Degrees.FirstOrDefault(x => x.Id == id);
        }
    }
}
