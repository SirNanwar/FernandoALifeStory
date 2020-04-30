using System.Collections.Generic;

namespace FernandoALifeStory.Data.Models.Courses
{
    public class CoursePlatform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}