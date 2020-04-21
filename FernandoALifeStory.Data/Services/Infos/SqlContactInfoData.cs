using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using FernandoALifeStory.Data.Models.Infos;

namespace FernandoALifeStory.Data.Services.Infos
{
    public class SqlContactInfoData : IContactInfoData
    {
        private readonly FernandoDbContext db;

        public SqlContactInfoData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ContactInfo> GetAll()
        {
            return db.ContactInfos.OrderBy(x => x.ContactType);
        }

        public ContactInfo GetById(int id)
        {
            return db.ContactInfos.FirstOrDefault(x => x.Id == id);
        }
    }
}
