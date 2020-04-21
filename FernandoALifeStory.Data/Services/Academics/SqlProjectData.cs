using FernandoALifeStory.Data.Models.Academics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Academics
{
    public class SqlProjectData : IProjectData
    {
        private readonly FernandoDbContext db;

        public SqlProjectData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Project> GetAll()
        {
            return db.Projects.OrderBy(x => x.Name);
        }

        public Project GetById(int id)
        {
            return db.Projects.FirstOrDefault(x => x.Id == id);
        }
    }
}
