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
            Skill mvcSkill = SkillGetOrAdd(context, "MVC", SkillType.DesignPatternSkill);
            Skill dotNETSkill = SkillGetOrAdd(context, ".NET", SkillType.TechnologySkill);
            Skill CSharpSkill = SkillGetOrAdd(context, "C#", SkillType.TechnologySkill);
            Skill designPatternsSkill = SkillGetOrAdd(context, "Design Patterns", SkillType.DesignPatternSkill);

            CoursePlatform pluralsightPlatform = context.CoursePlatforms.FirstOrDefault(x => x.Name.Equals("Pluralsight"));
            if (pluralsightPlatform is null)
            {
                pluralsightPlatform = new CoursePlatform() { Name = "Pluralsight" };
                context.CoursePlatforms.Add(pluralsightPlatform);
                context.SaveChanges();
            }
            if(context.CoursePlatforms.Any(x => x.Name.Equals("Pluralsight")))
            {
                Course aspDotNetMVCFundamentals = context.Courses.FirstOrDefault(x => x.CourseName.Equals("ASP.NET MVC 5 Fundamentals"));
                if (aspDotNetMVCFundamentals is null)
                {
                    aspDotNetMVCFundamentals = new Course()
                    {
                        CourseName = "ASP.NET MVC 5 Fundamentals",
                        CoursePlatformId = pluralsightPlatform.Id,
                        CoursePlatform = pluralsightPlatform,
                        Description = "Fundamentals for ASP.NET MVC 5",
                        Skills = new List<Skill>()
                        {
                            aspDotNetSkill,
                            mvcSkill,
                            dotNETSkill,
                            CSharpSkill
                        }
                    };
                    context.Courses.Add(aspDotNetMVCFundamentals);
                }
                /*
                Add other courses here from the same platform 
                */
                context.SaveChanges();
            }

            CoursePlatform udemyPlatform = context.CoursePlatforms.FirstOrDefault(x => x.Name.Equals("Udemy"));
            if (udemyPlatform is null)
            {
                udemyPlatform = new CoursePlatform() { Name = "Udemy" };
                context.CoursePlatforms.Add(udemyPlatform);
                context.SaveChanges();
            }
            if (context.CoursePlatforms.Any(x => x.Name.Equals("Udemy")))
            {
                Course designPatternsInCSharp = context.Courses.FirstOrDefault(x => x.CourseName.Equals("Design Patterns in C# and .NET"));
                if (designPatternsInCSharp is null)
                {
                    designPatternsInCSharp = new Course()
                    {
                        CourseName = "Design Patterns in C# and .NET",
                        CoursePlatform = udemyPlatform,
                        CoursePlatformId = udemyPlatform.Id,
                        Description = "A comprehensive overview of Design Patterns in C# and .NET from a practical perspective.",
                        Skills = new List<Skill>()
                        {
                            dotNETSkill,
                            CSharpSkill,
                            designPatternsSkill
                        }
                    };
                    context.Courses.Add(designPatternsInCSharp);
                }
                /*
                Add other courses here from the same platform 
                */
                context.SaveChanges();
            }

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
