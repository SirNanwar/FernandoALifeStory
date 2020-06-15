using System;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Models.Certifications
{
    public class Certification
    {
        public int Id { get; set; }
        public string CertificationName { get; set; }
        public DateTime AdquiredAt { get; set; }
        public List<CertificationSkill> CertificationSkills { get; set; }
    }
}