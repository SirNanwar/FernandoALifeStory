using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Models.Skills;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.AcademicContext
{
    internal class AcademicSkillContextExtension
    {
        public static void AddDisciplineSkillRelations(FernandoDbContext context, Discipline discipline, Skill[] skills)
        {
            foreach (Skill skill in skills)
            {
                DisciplineSkill disciplineSkill = new DisciplineSkill()
                {
                    DisciplineId = discipline.Id,
                    Discipline = discipline,
                    SkillId = skill.Id,
                    Skill = skill
                };

                discipline.DisciplineSkills.Add(disciplineSkill);
                skill.DisciplineSkills.Add(disciplineSkill);

                context.DisciplineSkills.Add(disciplineSkill);

                context.Disciplines.Update(discipline);
                context.Skills.Update(skill);
            }

            context.SaveChanges();
        }
    }
}