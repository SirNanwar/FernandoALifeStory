using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Services.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Certifications
{
    public class SqlCertificationSkillData : ICertificationSkillData
    {
        private readonly DbSet<CertificationSkill> certificationSkills;

        public SqlCertificationSkillData(FernandoDbContext db)
        {
            this.certificationSkills = db.CertificationSkills;
        }

        public IEnumerable<CertificationSkill> GetAll()
        {
            return certificationSkills.OrderBy(x => x.CertificationId);
        }

        public IEnumerable<CertificationSkill> GetByCertificationId(int certificationId)
        {
            return certificationSkills.Where(x => x.CertificationId == certificationId);
        }

        public IEnumerable<CertificationSkill> GetBySkillId(int skillId)
        {
            return certificationSkills.Where(x => x.SkillId == skillId);
        }

        public CertificationSkill GetByCertificationAndSkillIds(int certificationId, int skillId)
        {
            return certificationSkills.FirstOrDefault(x => x.CertificationId == certificationId &&
                                                           x.SkillId == skillId);
        }
    }
}
