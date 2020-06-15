using FernandoALifeStory.Data.Context.DbContextExtensions.SkillContext;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.CourseContext
{
    static class CourseContextExtension
    {
        public static void SeedCourses(FernandoDbContext context, SkillContextExtension skillsContext)
        {
            CoursePlatform pluralsightPlatform = CoursePlatformGetOrAdd(context, CourseNames.Platforms.pluralsight);
            if (context.CoursePlatforms.Any(x => x.Name.Equals(pluralsightPlatform.Name)))
            {
                Course aspDotNetMVCFundamentals = CourseGetOrAdd(context, pluralsightPlatform, CourseNames.AspDotNetMvc.name, CourseNames.AspDotNetMvc.description, skillsContext.Skills[SkillName.ASPDOTNET], skillsContext.Skills[SkillName.MVC], skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP]);
                Course entityFrameworkCore2GettingStarted = CourseGetOrAdd(context, pluralsightPlatform, CourseNames.EFCoreStart.name, CourseNames.EFCoreStart.description, skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP], skillsContext.Skills[SkillName.EFCORE], skillsContext.Skills[SkillName.ORM]);
                Course cSharpFundamentals = CourseGetOrAdd(context, pluralsightPlatform, CourseNames.CSharpFundament.name, CourseNames.CSharpFundament.description, skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP]);
            }

            CoursePlatform udemyPlatform = CoursePlatformGetOrAdd(context, CourseNames.Platforms.udemy);
            if (context.CoursePlatforms.Any(x => x.Name.Equals(udemyPlatform.Name)))
            {
                Course designPatternsInCSharp = CourseGetOrAdd(context, udemyPlatform, CourseNames.DPatternsCSharp.name, CourseNames.DPatternsCSharp.description, skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP], skillsContext.Skills[SkillName.DP]);
                Course automateTheBoringStuffWithPython = CourseGetOrAdd(context, udemyPlatform, CourseNames.AutoBoringStuffPython.name, CourseNames.AutoBoringStuffPython.description, skillsContext.Skills[SkillName.PYTHON], skillsContext.Skills[SkillName.WEBSCRAP], skillsContext.Skills[SkillName.AUTOMATION]);
            }
        }

        private static CoursePlatform CoursePlatformGetOrAdd(FernandoDbContext context, string platformName)
        {
            CoursePlatform platform = context.CoursePlatforms.FirstOrDefault(x => x.Name.Equals(platformName));
            if (platform is null)
            {
                platform = new CoursePlatform() { Name = platformName };
                context.CoursePlatforms.Add(platform);
                context.SaveChanges();
            }
            platform.Courses ??= new List<Course>();
            return platform;
        }

        private static Course CourseGetOrAdd(FernandoDbContext context, CoursePlatform coursePlatform, string courseName, string courseDescription, params Skill[] skills)
        {
            Course course = context.Courses.FirstOrDefault(x => x.CourseName.Equals(courseName));
            if (course is null)
            {
                course = new Course()
                {
                    CourseName = courseName,
                    CoursePlatformId = coursePlatform.Id,
                    CoursePlatform = coursePlatform,
                    Description = courseDescription,
                    CourseSkills = new List<CourseSkill>()
                };

                coursePlatform.Courses.Add(course);
                context.CoursePlatforms.Update(coursePlatform);

                context.Courses.Add(course);
                context.SaveChanges();

                SkillRelationContextExtension.AddSkillRelations(context, course, skills);
            }

            return course;
        }
    }
}
