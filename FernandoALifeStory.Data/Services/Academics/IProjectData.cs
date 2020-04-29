using FernandoALifeStory.Data.Models.Academics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Academics
{
    public interface IProjectData
    {
        IEnumerable<Project> GetAll();
        Project GetById(int id);
        IEnumerable<Project> GetProjectsByDisciplineId(int id);
    }
}
