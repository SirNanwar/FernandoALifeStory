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
            CoursePlatform pluralsightPlatform = CoursePlatformGetOrAdd(context, "Pluralsight");
            if (context.CoursePlatforms.Any(x => x.Name.Equals(pluralsightPlatform.Name)))
            {
                Course aspDotNetMVCFundamentals = CourseGetOrAdd(context, pluralsightPlatform, "ASP.NET MVC 5 Fundamentals", "Fundamentals to ASP.NET MVC", skillsContext.Skills[SkillName.ASPDOTNET], skillsContext.Skills[SkillName.MVC], skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP]);
                Course entityFrameworkCore2GettingStarted = CourseGetOrAdd(context, pluralsightPlatform, "Entity Framework Core 2: Getting Started", "First introduction to Entity Framework Core 2, a Microsot O/RM", skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP], skillsContext.Skills[SkillName.EFCORE], skillsContext.Skills[SkillName.ORM]);
                Course cSharpFundamentals = CourseGetOrAdd(context, pluralsightPlatform, "C# Fundamentals", "Fundamentals to C# programming", skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP]);
            }

            CoursePlatform udemyPlatform = CoursePlatformGetOrAdd(context, "Udemy");
            if (context.CoursePlatforms.Any(x => x.Name.Equals(udemyPlatform.Name)))
            {
                Course designPatternsInCSharp = CourseGetOrAdd(context, udemyPlatform, "Design Patterns in C# and .NET", "A comprehensive overview of Design Patterns in C# and .NET from a practical perspective.", skillsContext.Skills[SkillName.DOTNET], skillsContext.Skills[SkillName.CSHARP], skillsContext.Skills[SkillName.DP]);
                Course automateTheBoringStuffWithPython = CourseGetOrAdd(context, udemyPlatform, "Automate the Boring Stuff with Python Programming", "If you're an office worker, student, administrator, or just want to become more productive with your computer, programming will allow you write code that can automate tedious tasks. This course follows the popular (and free!) book, Automate the Boring Stuff with Python.", skillsContext.Skills[SkillName.PYTHON], skillsContext.Skills[SkillName.WEBSCRAP], skillsContext.Skills[SkillName.AUTOMATION]);
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
