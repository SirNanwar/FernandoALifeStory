using FernandoALifeStory.Data.Models.Skills;
using FernandoALifeStory.Data.Models.WorkExperiences;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.WorkContext
{
    internal class WorkSkillContextExtension
    {
        public static void AddWorkSkillRelations(FernandoDbContext context, Work w, Skill[] skills)
        {
            foreach (Skill skill in skills)
            {
                WorkSkill workSkill = new WorkSkill()
                {
                    WorkId = w.Id,
                    Work = w,
                    SkillId = skill.Id,
                    Skill = skill
                };

                w.WorkSkills.Add(workSkill);
                skill.WorkSkills.Add(workSkill);

                context.WorkSkills.Add(workSkill);

                context.Works.Update(w);
                context.Skills.Update(skill);
            }

            context.SaveChanges();
        }
    }
}