using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Skills
{
    interface ISkillData
    {
        IEnumerable<Skill> GetAll();
        Skill GetById(int id);
    }
}
