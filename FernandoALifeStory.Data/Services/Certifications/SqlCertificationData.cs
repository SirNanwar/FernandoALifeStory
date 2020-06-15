using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.Certifications;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Services.Certifications
{
    public class SqlCertificationData : ICertificationData
    {
        private readonly DbSet<Certification> certifications;

        public SqlCertificationData(FernandoDbContext db)
        {
            this.certifications = db.Certifications;
        }

        public IEnumerable<Certification> GetAll()
        {
            return certifications.OrderBy(x => x.CertificationName);
        }

        public Certification GetById(int id)
        {
            return certifications.FirstOrDefault(x => x.Id == id);
        }
    }
}