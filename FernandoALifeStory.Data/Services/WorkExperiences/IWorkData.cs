using FernandoALifeStory.Data.Models.WorkExperiences;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public interface IWorkData
    {
        IEnumerable<Work> GetAll();
        Work GetById(int id);
        IEnumerable<Achievement> GetAchievementsByWorkId(int id);
    }
}
