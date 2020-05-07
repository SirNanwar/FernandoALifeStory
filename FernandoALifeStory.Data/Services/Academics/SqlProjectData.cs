using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Services.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Academics
{
    public class SqlProjectData : IProjectData
    {
        private readonly DbSet<Project> projects;

        public SqlProjectData(FernandoDbContext db)
        {
            this.projects = db.Projects;
        }

        public IEnumerable<Project> GetAll()
        {
            return projects.OrderBy(x => x.Name);
        }

        public Project GetById(int id)
        {
            return projects.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Project> GetProjectsByDisciplineId(int id)
        {
            return projects.Where(x => x.DisciplineId == id);
        }
    }
}
