using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FernandoALifeStory.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
