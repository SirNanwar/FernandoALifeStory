using FernandoALifeStory.Data.Models.WorkExperiences;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public interface IAchievementData
    {
        IEnumerable<Achievement> GetAll();
        Achievement GetById(int id);
    }
}
