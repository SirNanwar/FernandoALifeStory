﻿using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.Skills;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Services.Skills
{
    public class SqlSkillData : ISkillData
    {
        private readonly DbSet<Skill> skills;

        public SqlSkillData(FernandoDbContext db)
        {
            this.skills = db.Skills;
        }

        public IEnumerable<Skill> GetAll()
        {
            return skills.OrderBy(x => x.Name);
        }

        public Skill GetById(int id)
        {
            return skills.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Skill> GetSkillsByMultipleIds(int[] ids)
        {
            return skills.Where(x => ids.Contains(x.Id)).OrderBy(x => x.Type);
        }
    }
}