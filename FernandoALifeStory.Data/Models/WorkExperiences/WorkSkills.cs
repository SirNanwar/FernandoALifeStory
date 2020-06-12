using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.WorkExperiences
{
    public class WorkSkills
    {
        public int WorkId { get; set; }
        public Work Work { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
