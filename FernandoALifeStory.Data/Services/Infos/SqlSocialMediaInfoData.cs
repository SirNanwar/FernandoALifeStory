using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using FernandoALifeStory.Data.Models.Infos;

namespace FernandoALifeStory.Data.Services.Infos
{
    public class SqlSocialMediaInfoData : ISocialMediaInfoData
    {
        private readonly FernandoDbContext db;

        public SqlSocialMediaInfoData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SocialMediaInfo> GetAll()
        {
            return db.SocialMediaInfos.OrderBy(x => x.Type);
        }

        public SocialMediaInfo GetById(int id)
        {
            return db.SocialMediaInfos.FirstOrDefault(x => x.Id == id);
        }
    }
}
