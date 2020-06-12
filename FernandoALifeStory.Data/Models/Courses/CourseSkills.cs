using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.Courses
{
    public class CourseSkills
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
