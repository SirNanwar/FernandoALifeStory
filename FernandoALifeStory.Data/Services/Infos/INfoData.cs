using FernandoALifeStory.Data.Models.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Infos
{
    public interface INfoData
    {
        IEnumerable<Info> GetAll();
        Info GetById(int id);
    }
}