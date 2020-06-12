﻿using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.Certifications
{
    public class CertificationSkills
    {
        public int CertificationId { get; set; }
        public Certification Certification { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
