using FernandoALifeStory.Data.Models.Skills;

namespace FernandoALifeStory.Data.Models.Certifications
{
    public class CertificationSkill
    {
        public int CertificationId { get; set; }
        public Certification Certification { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}