using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Models.Academics
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ECTs { get; set; }
        public List<Project> Project { get; set; }
        public List<Skill> Skills { get; set; }
        public Degree Degree { get; set; }
        public int DegreeId { get; set; }
    }
}