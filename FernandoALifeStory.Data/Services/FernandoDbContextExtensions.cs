using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services
{
    public static class FernandoDbContextExtensions
    {
        public static void EnsureDatabaseSeeded(this FernandoDbContext context)
        {
            /*
            Process for courses, replicate to others:
                Books and Certifications will not need the nesting
                Academics will need another level of nesting
                WorkExperiences will be the same

            Create all the needed skills and use in the creation of all the objects that need skills
                
            if Platorfm 1 does not exist
                create platform 1
            if platform 1 exists
                if couse A1 does not exist
                    create couse A1
                if course B1 does not exist
                    create course B1
                (..repeat for other couses from 1..)
            
            if Platorfm 2 does not exist
                create platform 2
            if platform 2 exists
                if couse A2 does not exist
                    create couse A2
                if course B2 does not exist
                    create course B2
                (..repeat for other couses from 2..)
            
            (..Repeat for other platforms..)

            [.....] All the other being made
             */

            Skill aspDotNetSkill = SkillGetOrAdd(context, "ASP.Net", SkillType.TechnologySkill);
            Skill mvcSkill = SkillGetOrAdd(context, "MVC", SkillType.PatternSkill);
            Skill dotNETSkill = SkillGetOrAdd(context, ".NET", SkillType.TechnologySkill);
            Skill CSharpSkill = SkillGetOrAdd(context, "C#", SkillType.TechnologySkill);
            Skill designPatternsSkill = SkillGetOrAdd(context, "Design Patterns", SkillType.PatternSkill);
            Skill entityFrameworkCoreSkill = SkillGetOrAdd(context, "Entity Framework Core", SkillType.TechnologySkill);
            Skill ormSkill = SkillGetOrAdd(context, "Object-Relational Mappers", SkillType.TechnologySkill);

            #region Books

            #endregion

            #region Certifications

            #endregion

            #region Courses
            CoursePlatform pluralsightPlatform = CoursePlatformGetOrAdd(context, "Pluralsight");
            if(context.CoursePlatforms.Any(x => x.Name.Equals(pluralsightPlatform.Name)))
            {
                Course aspDotNetMVCFundamentals = CourseGetOrAdd(context, pluralsightPlatform, "ASP.NET MVC 5 Fundamentals", "Fundamentals to ASP.NET MVC", aspDotNetSkill, mvcSkill, dotNETSkill, CSharpSkill);
                Course entityFrameworkCore2GettingStarted = CourseGetOrAdd(context, pluralsightPlatform, "Entity Framework Core 2: Getting Started", "First introduction to Entity Framework Core 2, a Microsot O/RM", dotNETSkill, CSharpSkill, entityFrameworkCoreSkill, ormSkill);
                Course cSharpFundamentals = CourseGetOrAdd(context, pluralsightPlatform, "C# Fundamentals", "Fundamentals to C# programming", dotNETSkill, CSharpSkill);

                /*
                Add other courses here from the same platform 
                */
                context.SaveChanges();
            }

            CoursePlatform udemyPlatform = CoursePlatformGetOrAdd(context, "Udemy");
            if (context.CoursePlatforms.Any(x => x.Name.Equals(udemyPlatform.Name)))
            {
                Course designPatternsInCSharp = CourseGetOrAdd(context, udemyPlatform, "Design Patterns in C# and .NET", "A comprehensive overview of Design Patterns in C# and .NET from a practical perspective.", dotNETSkill, CSharpSkill, designPatternsSkill);

                /*
                Add other courses here from the same platform 
                */
                context.SaveChanges();
            }
            #endregion

            #region Work Experiences

            #endregion

            #region Academics

            #endregion
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
                    Skills = skills.ToList()
                };
                context.Courses.Add(course);
            }

            return course;
        }

        private static Skill SkillGetOrAdd(FernandoDbContext context, string skillName, SkillType skillType)
        {
            Skill skill = context.Skills.FirstOrDefault(x => x.Name.Equals(skillName) && 
                                                                 x.Type == skillType);
            if (skill is null)
            {
                skill = new Skill() { Name = skillName, Type = skillType };
                context.Skills.Add(skill);
                context.SaveChangesAsync();
            }

            return skill;
        }
    }
}
