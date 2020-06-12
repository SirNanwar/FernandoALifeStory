using FernandoALifeStory.Data.Models.WorkExperiences;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public interface IWorkSkillData
    {
        IEnumerable<WorkSkill> GetAll();
        IEnumerable<WorkSkill> GetByWorkId(int workId);
        IEnumerable<WorkSkill> GetBySkillId(int skillId);
        WorkSkill GetByWorkAndSkillIds(int workId, int skillId);
    }
}
