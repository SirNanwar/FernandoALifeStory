using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.WorkExperiences;
using System.Collections.Generic;
using System.ComponentModel;

namespace FernandoALifeStory.Data.Models.Skills
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SkillProficiency Proficiency { get; set; }
        public SkillType Type { get; set; }

        public List<DisciplineSkill> DisciplineSkills { get; set; }
        public List<BookSkills> BookSkills { get; set; }
        public List<CertificationSkills> CertificationSkills { get; set; }
        public List<CourseSkills> CourseSkills { get; set; }
        public List<WorkSkills> WorkSkills { get; set; }
    }
}
