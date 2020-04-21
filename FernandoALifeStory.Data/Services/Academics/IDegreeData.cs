using FernandoALifeStory.Data.Models.Academics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Academics
{
    public interface IDegreeData
    {
        IEnumerable<Degree> GetlAll();
        Degree GetById(int id);
    }
}
