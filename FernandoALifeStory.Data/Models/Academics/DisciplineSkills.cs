using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.Academics
{
    public class DisciplineSkill
    {
        public int DisciplineId { get; set; } 
        public Discipline Discipline { get; set; } 

        public int SkillId { get; set; } 
        public Skill Skill { get; set; } 
    }
}
