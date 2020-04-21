using FernandoALifeStory.Data.Models.Certifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Certifications
{
    public class SqlCertificationData : ICertificationData
    {
        private readonly FernandoDbContext db;

        public SqlCertificationData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Certification> GetAll()
        {
            return db.Certifications.OrderBy(x => x.CertificationName);
        }

        public Certification GetById(int id)
        {
            return db.Certifications.FirstOrDefault(x => x.Id = id);
        }
    }
}
