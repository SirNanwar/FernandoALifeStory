using FernandoALifeStory.Data.Models.Academics;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Academics
{
    public interface IProjectData
    {
        IEnumerable<Project> GetAll();

        Project GetById(int id);

        IEnumerable<Project> GetProjectsByDisciplineId(int id);
    }
}