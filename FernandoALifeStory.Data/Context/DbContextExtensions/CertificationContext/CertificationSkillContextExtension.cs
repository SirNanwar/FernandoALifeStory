using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Models.Skills;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.CertificationContext
{
    internal class CertificationSkillContextExtension
    {
        public static void AddCertificationSkillRelations(FernandoDbContext context, Certification certification, Skill[] skills)
        {
            foreach (Skill skill in skills)
            {
                CertificationSkill certificationSkill = new CertificationSkill()
                {
                    CertificationId = certification.Id,
                    Certification = certification,
                    SkillId = skill.Id,
                    Skill = skill
                };

                certification.CertificationSkills.Add(certificationSkill);
                skill.CertificationSkills.Add(certificationSkill);

                context.CertificationSkills.Add(certificationSkill);

                context.Certifications.Update(certification);
                context.Skills.Update(skill);
            }

            context.SaveChanges();
        }
    }
}