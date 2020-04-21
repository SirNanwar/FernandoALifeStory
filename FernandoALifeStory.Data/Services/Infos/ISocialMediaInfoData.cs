using FernandoALifeStory.Data.Models.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Infos
{
    public interface ISocialMediaInfoData
    {
        IEnumerable<SocialMediaInfo> GetAll();
        SocialMediaInfo GetById(int id);
    }
}
