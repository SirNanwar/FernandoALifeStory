using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.Certifications
{
    public class Certification
    {
        public int Id { get; set; }
        public string CertificationName { get; set; }
        public DateTime AdquiredAt { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
