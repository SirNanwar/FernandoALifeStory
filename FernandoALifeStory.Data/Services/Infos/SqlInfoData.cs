using FernandoALifeStory.Data.Models.Infos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Infos
{
    public class SqlInfoData : INfoData
    {
        private readonly FernandoDbContext db;

        public SqlInfoData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Info> GetAll()
        {
            return db.Info.OrderBy(x => x.Name);
        }

        public Info GetById(int id)
        {
            return db.Info.FirstOrDefault(x => x.Id == id);
        }
    }
}
