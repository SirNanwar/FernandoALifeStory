using FernandoALifeStory.Data.Models.Certifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Certifications
{
    public interface ICertificationSkillData
    {
        IEnumerable<CertificationSkill> GetAll();
        IEnumerable<CertificationSkill> GetByCertificationId(int certificationId);
        IEnumerable<CertificationSkill> GetBySkillId(int skillId);
        CertificationSkill GetByCertificationAndSkillIds(int certificationId, int skillId);
    }
}
