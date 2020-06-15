using FernandoALifeStory.Data.Models.Skills;

namespace FernandoALifeStory.Data.Models.WorkExperiences
{
    public class WorkSkill
    {
        public int WorkId { get; set; }
        public Work Work { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}