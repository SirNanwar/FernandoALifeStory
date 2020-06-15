using FernandoALifeStory.Data.Models.Academics;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Academics
{
    public interface IDisciplineSkillData
    {
        IEnumerable<DisciplineSkill> GetAll();

        IEnumerable<DisciplineSkill> GetByDisciplineId(int disciplineId);

        IEnumerable<DisciplineSkill> GetBySkillId(int skillId);

        DisciplineSkill GetByDisciplineAndSkillIds(int disciplineId, int skillId);
    }
}