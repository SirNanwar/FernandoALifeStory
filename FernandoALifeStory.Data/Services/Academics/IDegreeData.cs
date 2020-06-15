using FernandoALifeStory.Data.Models.Academics;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Academics
{
    public interface IDegreeData
    {
        IEnumerable<Degree> GetAll();

        Degree GetById(int id);
    }
}