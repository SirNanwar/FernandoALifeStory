using FernandoALifeStory.Data.Models.Academics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Academics
{
    public interface IDisciplineData
    {
        IEnumerable<Discipline> GetAll();
        Discipline GetById(int id);
    }
}
