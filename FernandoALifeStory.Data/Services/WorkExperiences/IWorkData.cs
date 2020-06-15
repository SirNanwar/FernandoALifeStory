using FernandoALifeStory.Data.Models.WorkExperiences;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public interface IWorkData
    {
        IEnumerable<Work> GetAll();

        Work GetById(int id);
    }
}