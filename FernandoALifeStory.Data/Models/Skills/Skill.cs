using System.ComponentModel;

namespace FernandoALifeStory.Data.Models.Skills
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SkillProficiency Proficiency { get; set; }
        public SkillType Type { get; set; }
    }
}
