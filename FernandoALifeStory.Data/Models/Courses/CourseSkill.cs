using FernandoALifeStory.Data.Models.Skills;

namespace FernandoALifeStory.Data.Models.Courses
{
    public class CourseSkill
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}