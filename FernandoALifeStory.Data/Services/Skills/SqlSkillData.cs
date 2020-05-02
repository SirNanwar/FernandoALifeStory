using FernandoALifeStory.Data.Models.Skills;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
