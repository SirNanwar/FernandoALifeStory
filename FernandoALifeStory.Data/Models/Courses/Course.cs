using FernandoALifeStory.Data.Models.Transversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.Courses
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public List<Skill> Skills { get; set; }
        public CoursePlatform CoursePlatform { get; set; }
        public int CoursePlatformId { get; set; }
    }
}
