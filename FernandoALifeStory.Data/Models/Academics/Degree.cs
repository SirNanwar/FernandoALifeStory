using System;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Models.Academics
{
    public class Degree
    {
        public int Id { get; set; }
        public string Field { get; set; }
        public EducationLevel Level { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public List<Discipline> Curriculum { get; set; }
    }
}