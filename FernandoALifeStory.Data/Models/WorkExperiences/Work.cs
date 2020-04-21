﻿using FernandoALifeStory.Data.Models.Transversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.WorkExperiences
{
    public class Work
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Achievement> Achievements { get; set; }
        public List<Skill> Skills { get; set; }
    }
}