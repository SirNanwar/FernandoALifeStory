using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Transversal;
using System;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Models.Academics
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ECTs { get; set; }
        public Project Project { get; set; }
        public List<Skill> Skills { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}