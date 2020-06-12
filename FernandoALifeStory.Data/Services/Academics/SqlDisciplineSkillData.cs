using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Services.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Academics
{
    public class SqlDisciplineSkillData : IDisciplineSkillData
    {
        private readonly DbSet<DisciplineSkill> disciplineSkills;

        public SqlDisciplineSkillData(FernandoDbContext db)
        {
            this.disciplineSkills = db.DisciplineSkills;
        }

        public IEnumerable<DisciplineSkill> GetAll()
        {
            return disciplineSkills.OrderBy(x => x.DisciplineId);
        }

        public IEnumerable<DisciplineSkill> GetByDisciplineId(int disciplineId)
        {
            return disciplineSkills.Where(x => x.DisciplineId == disciplineId);
        }

        public IEnumerable<DisciplineSkill> GetBySkillId(int skillId)
        {
            return disciplineSkills.Where(x => x.SkillId == skillId);
        }

        public DisciplineSkill GetByDisciplineAndSkillIds(int disciplineId, int skillId)
        {
            return disciplineSkills.FirstOrDefault(x => x.DisciplineId == disciplineId &&
                                                        x.SkillId == skillId);
        }
    }
}
