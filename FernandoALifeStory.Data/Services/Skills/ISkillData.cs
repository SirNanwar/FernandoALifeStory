using FernandoALifeStory.Data.Models.Skills;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Skills
{
    public interface ISkillData
    {
        IEnumerable<Skill> GetAll();

        Skill GetById(int id);

        IEnumerable<Skill> GetSkillsByMultipleIds(int[] ids);
    }
}