using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.WorkExperiences;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public class SqlWorkSkillData : IWorkSkillData
    {
        private readonly DbSet<WorkSkill> workSkills;

        public SqlWorkSkillData(FernandoDbContext db)
        {
            this.workSkills = db.WorkSkills;
        }

        public IEnumerable<WorkSkill> GetAll()
        {
            return workSkills.OrderBy(x => x.WorkId);
        }

        public IEnumerable<WorkSkill> GetByWorkId(int workId)
        {
            return workSkills.Where(x => x.WorkId == workId);
        }

        public IEnumerable<WorkSkill> GetBySkillId(int skillId)
        {
            return workSkills.Where(x => x.SkillId == skillId);
        }

        public WorkSkill GetByWorkAndSkillIds(int workId, int skillId)
        {
            return workSkills.FirstOrDefault(x => x.WorkId == workId &&
                                                  x.SkillId == skillId);
        }
    }
}
