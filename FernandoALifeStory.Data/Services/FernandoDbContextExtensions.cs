using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using FernandoALifeStory.Data.Models.WorkExperiences;
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
            Skill cleanCodeSkill = SkillGetOrAdd(context, "Clean Code", SkillType.ConceptSkill);
            Skill unitTestingSkill = SkillGetOrAdd(context, "Unit Testing", SkillType.ConceptSkill);
            Skill agileMethodologiesSkill = SkillGetOrAdd(context, "Agile Methodologies", SkillType.ConceptSkill);
            Skill automatedTestingSkill = SkillGetOrAdd(context, "Automated Testing", SkillType.ConceptSkill);
            Skill restAPISkill = SkillGetOrAdd(context, "REST API", SkillType.PatternSkill);
            Skill voipSkill = SkillGetOrAdd(context, "VoIP Development", SkillType.ConceptSkill);
            Skill cyberSecuritySkill = SkillGetOrAdd(context, "Cyber Security and Encryption", SkillType.ConceptSkill);
            Skill continuousIntegrationSkill = SkillGetOrAdd(context, "Continuous Integration", SkillType.ConceptSkill);
            Skill CPPSkill = SkillGetOrAdd(context, "C++", SkillType.LanguageSkill);
            Skill SQLServerSkill = SkillGetOrAdd(context, "SQL Server", SkillType.TechnologySkill);
            Skill visualStudioSkill = SkillGetOrAdd(context, "Visual Studio", SkillType.TechnologySkill);
            Skill azureDevOpsSkill = SkillGetOrAdd(context, "Azure DevOps", SkillType.TechnologySkill);
            Skill seleniumSkill = SkillGetOrAdd(context, "Selenium WebDriver", SkillType.TechnologySkill);

            #region Books
            Book cleanCodeBook = BookGetOrAdd(context, "Clean Code", "Robert C. Martin", "A Handbook of Agile Software Craftsmanship", designPatternsSkill, cleanCodeSkill, unitTestingSkill, agileMethodologiesSkill);
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
            }

            CoursePlatform udemyPlatform = CoursePlatformGetOrAdd(context, "Udemy");
            if (context.CoursePlatforms.Any(x => x.Name.Equals(udemyPlatform.Name)))
            {
                Course designPatternsInCSharp = CourseGetOrAdd(context, udemyPlatform, "Design Patterns in C# and .NET", "A comprehensive overview of Design Patterns in C# and .NET from a practical perspective.", dotNETSkill, CSharpSkill, designPatternsSkill);
            }
            #endregion

            #region Work Experiences
            Work collabWork = WorkExperienceGetOrAdd(context, "Collab", "Software Engineer", new DateTime(2018, 08, 10), null, 
                dotNETSkill, CSharpSkill, entityFrameworkCoreSkill, ormSkill, 
                unitTestingSkill, agileMethodologiesSkill, automatedTestingSkill, restAPISkill, 
                voipSkill, cyberSecuritySkill, continuousIntegrationSkill, CPPSkill, 
                SQLServerSkill, visualStudioSkill, azureDevOpsSkill, seleniumSkill);
            if (context.WorkExperiences.Any(x => x.CompanyName.Equals(collabWork.CompanyName)))
            {
                Achievement microsservice = AchievementGetOrAdd(context, collabWork, "Developed a microservice REST API of asynchronous messaging with Entity Framework Core.");
                Achievement encryption = AchievementGetOrAdd(context, collabWork, "Implemented real time encryption of RTP video calls. ");
                Achievement autoTest = AchievementGetOrAdd(context, collabWork, "Guaranteed product continuous integration, developing integration and functional automated testing.");
                Achievement sipDev = AchievementGetOrAdd(context, collabWork, "Worked on developing SIP solutions for VoIP calls. ");
            }
            #endregion

            #region Academics

            #endregion
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
                context.WorkExperiences.Update(work);
                
                context.Achievements.Add(achievement);
                context.SaveChanges();
            }
            return achievement;
        }

        private static Work WorkExperienceGetOrAdd(FernandoDbContext context, string companyName, string position, DateTime startDate, DateTime? endDate, params Skill[] skills)
        {
            Work work = context.WorkExperiences.FirstOrDefault(x => x.CompanyName.Equals(companyName));
            if (work is null)
            {
                work = new Work()
                {
                    CompanyName = companyName,
                    Position = position,
                    StartDate = startDate,
                    EndDate = endDate,
                    Skills = skills.ToList()
                };
                context.WorkExperiences.Add(work);
                context.SaveChanges();
            }
            return work;
        }

        private static Book BookGetOrAdd(FernandoDbContext context, string bookName, string bookAuthor, string bookDescription, params Skill[] skills)
        {
            Book book = context.Books.FirstOrDefault(x => x.Name.Equals(bookName));
            if (book is null)
            {
                book = new Book()
                {
                    Name = bookName,
                    AuthorName = bookAuthor,
                    Description = bookDescription,
                    Skills = skills.ToList()
                };
                context.Books.Add(book);
                context.SaveChanges();
            }
            return book;
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
                coursePlatform.Courses.Add(course);
                context.CoursePlatforms.Update(coursePlatform);

                context.Courses.Add(course);
                context.SaveChanges();
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
