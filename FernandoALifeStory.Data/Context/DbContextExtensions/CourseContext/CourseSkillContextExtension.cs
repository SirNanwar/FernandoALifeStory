using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.CourseContext
{
    internal class CourseSkillContextExtension
    {
        public static void AddCourseSkillRelations(FernandoDbContext context, Course course, Skill[] skills)
        {
            foreach (Skill skill in skills)
            {
                CourseSkill courseSkill = new CourseSkill()
                {
                    CourseId = course.Id,
                    Course = course,
                    SkillId = skill.Id,
                    Skill = skill
                };

                course.CourseSkills.Add(courseSkill);
                skill.CourseSkills.Add(courseSkill);

                context.CourseSkills.Add(courseSkill);

                context.Courses.Update(course);
                context.Skills.Update(skill);
            }

            context.SaveChanges();
        }
    }
}