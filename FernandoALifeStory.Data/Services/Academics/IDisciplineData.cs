using FernandoALifeStory.Data.Models.Academics;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Academics
{
    public interface IDisciplineData
    {
        IEnumerable<Discipline> GetAll();

        Discipline GetById(int id);

        IEnumerable<Discipline> GetCurriculumByDegreeId(int id);
    }
}