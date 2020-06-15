using FernandoALifeStory.Data.Context.DbContextExtensions.SkillContext;
using FernandoALifeStory.Data.Models.Skills;
using FernandoALifeStory.Data.Models.WorkExperiences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.WorkContext
{
    static class WorkContextExtension
    {
        public static void SeedWorkExperiences(FernandoDbContext context, SkillContextExtension skillsContext)
        {
            Work collabWork = WorkExperienceGetOrAdd(context, "Collab", "Software Engineer", new DateTime(2018, 08, 10), null,
                skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP], skillsContext.Skills[SkillName.EFCORE], skillsContext.Skills[SkillName.ORM],
                skillsContext.Skills[SkillName.UNITTEST], skillsContext.Skills[SkillName.AGILE], skillsContext.Skills[SkillName.AUTOTEST], skillsContext.Skills[SkillName.REST],
                skillsContext.Skills[SkillName.VOIP], skillsContext.Skills[SkillName.CYBERSEC], skillsContext.Skills[SkillName.CI], skillsContext.Skills[SkillName.CPP],
                skillsContext.Skills[SkillName.SQLSERVER], skillsContext.Skills[SkillName.VS], skillsContext.Skills[SkillName.AZURE], skillsContext.Skills[SkillName.SELENIUM]);
            if (context.Works.Any(x => x.CompanyName.Equals(collabWork.CompanyName)))
            {
                Achievement microsservice = AchievementGetOrAdd(context, collabWork, "Developed a microservice REST API of asynchronous messaging with Entity Framework Core.");
                Achievement encryption = AchievementGetOrAdd(context, collabWork, "Implemented real time encryption of RTP video calls. ");
                Achievement autoTest = AchievementGetOrAdd(context, collabWork, "Guaranteed product continuous integration, developing integration and functional automated testing.");
                Achievement sipDev = AchievementGetOrAdd(context, collabWork, "Worked on developing SIP solutions for VoIP calls. ");
            }
        }

        private static Achievement AchievementGetOrAdd(FernandoDbContext context, Work work, string description)
        {
            Achievement achievement = context.Achievements.FirstOrDefault(x => x.Description.Equals(description));
            if (achievement is null)
            {
                achievement = new Achievement()
                {
                    Description = description,
                    Work = work,
                    WorkId = work.Id
                };

                work.Achievements.Add(achievement);
                context.Works.Update(work);

                context.Achievements.Add(achievement);
                context.SaveChanges();
            }
            return achievement;
        }

        private static Work WorkExperienceGetOrAdd(FernandoDbContext context, string companyName, string position, DateTime startDate, DateTime? endDate, params Skill[] skills)
        {
            Work work = context.Works.FirstOrDefault(x => x.CompanyName.Equals(companyName));
            if (work is null)
            {
                work = new Work()
                {
                    CompanyName = companyName,
                    Position = position,
                    StartDate = startDate,
                    EndDate = endDate,
                    WorkSkills = new List<WorkSkill>()
                };

                context.Works.Add(work);
                context.SaveChanges();

                SkillRelationContextExtension.AddSkillRelations(context, work, skills);
            }
            work.Achievements ??= new List<Achievement>();
            return work;
        }
    }
}
