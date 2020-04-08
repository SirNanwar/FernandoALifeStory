using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Skills> Skills { get; set; }
    }
}
