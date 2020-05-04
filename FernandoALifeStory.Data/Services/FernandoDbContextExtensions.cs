using FernandoALifeStory.Data.Models.Academics;
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
            Degree istCSDegree = DegreeGetOrAdd(context, "Computer Science and Engineering", EducationLevel.Bachelor, "Instituto Superior Técnico", new DateTime(2014, 09, 09), new DateTime(2018, 07, 10), "Lisbon - Portugal");
            if (context.Degrees.Any(x => x.Field.Equals(istCSDegree.Field) && x.Level.Equals(istCSDegree.Level)))
            {
                Discipline fp = DisciplineGetOrAdd(context, istCSDegree, "Fundamentos da programação", 7.5, /*fp skills*/);
                Discipline iac = DisciplineGetOrAdd(context, istCSDegree, "Introdução à Arquitectura de Computadores", 7.5, /*iac skills*/);
                Discipline iaed = DisciplineGetOrAdd(context, istCSDegree, "Introdução aos Algoritmos e Estruturas de Dados", 7.5, /*iaed skills*/);
                Discipline lp = DisciplineGetOrAdd(context, istCSDegree, "Lógica para Programação", 7.5, /* lp skills*/);
                Discipline so = DisciplineGetOrAdd(context, istCSDegree, "Sistemas Operativos", 6.0, /**/);
                Discipline asa = DisciplineGetOrAdd(context, istCSDegree, "Análise e Síntese de Algoritmos", 6.0, /**/);
                Discipline ipm = DisciplineGetOrAdd(context, istCSDegree, "Interfaces Pessoa Máquina", 7.5, /**/);
                Discipline bd = DisciplineGetOrAdd(context, istCSDegree, "Bases de Dados", 6.0, /**/);
                Discipline cg = DisciplineGetOrAdd(context, istCSDegree, "Computação Gráfica", 4.5, /**/);
                Discipline ia = DisciplineGetOrAdd(context, istCSDegree, "Inteligência Artificial", 7.5, LispSkill, SearchAlgorithmSkill, LearningAlgorithmSkill, KnowledgeRepresentationAndReasoningSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(ia.Name)))
                {
                    Project racer = ProjectGetOrAdd(context, ia, "Racetrack", "Create an agent to play Racetrack autonomously");
                }
                Discipline oc = DisciplineGetOrAdd(context, istCSDegree, "Organização de Computadores", 6.0, ComputerArquitectureSkill, MemoryManagementSkill);
                Discipline po = DisciplineGetOrAdd(context, istCSDegree, "Programação com Objectos", 6.0, JavaSkill, designPatternsSkill, OOPSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(po.Name)))
                {
                    Project interpretor = ProjectGetOrAdd(context, po, "Program Interpretor", "Create a program to manage a set of programs and expressions")
                }
                Discipline es = DisciplineGetOrAdd(context, istCSDegree, "Engenharia de Software", 7.5, JavaSkill, JUnitSkill, JMockitSkill, SpringBootSkill, JMeterSkill, MySQLSkill, unitTestingSkill, agileMethodologiesSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(es.Name)))
                {
                    Project adventureBuilder = ProjectGetOrAdd(context, es, "Adventure Builder", "Leisure activity offer system");
                }
                Discipline sd = DisciplineGetOrAdd(context, istCSDegree, "Sistemas Distribuídos", 7.5, WebServicesSkill, CryptographySkill);
                Discipline rc = DisciplineGetOrAdd(context, istCSDegree, "Redes de Computadores", 6.0, CloudComputingSkill, HTTPProtocolSkill);
                Discipline ams = DisciplineGetOrAdd(context, istCSDegree, "Análise e Modelação de Sistemas", 6.0, UMLSkill, ArchimateSkill, BPMNSkill, SysMLSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(ams.Name)))
                {
                    Project baik = ProjectGetOrAdd(context, ams, "BAIK", "Bicicle sharing business model");
                }
                Discipline comp = DisciplineGetOrAdd(context, istCSDegree, "Compiladores", 6.0, CPPSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(comp.Name)))
                {
                    Project gr8 = ProjectGetOrAdd(context, comp, "Gr8 language compilator", "Development of a compilator of a ficticious programming language gr8. Concepts of parsing, lexing and tokenizing.");
                }

                Discipline al = DisciplineGetOrAdd(context, istCSDegree, "Álgebra Linear", 6.0);
                Discipline md = DisciplineGetOrAdd(context, istCSDegree, "Matemática Discreta", 7.5);
                Discipline mo = DisciplineGetOrAdd(context, istCSDegree, "Mecânica e Ondas", 6.0);
                Discipline cdiI = DisciplineGetOrAdd(context, istCSDegree, "Cálculo Diferencial e Integral I", 6.0);
                Discipline eo = DisciplineGetOrAdd(context, istCSDegree, "Electromagnetismo e Óptica", 6.0);
                Discipline tc = DisciplineGetOrAdd(context, istCSDegree, "Teoria da Computação", 4.5);
                Discipline cdiII = DisciplineGetOrAdd(context, istCSDegree, "Cálculo Diferencial e Integral II", 7.5);
                Discipline pe = DisciplineGetOrAdd(context, istCSDegree, "Probabilidades e Estatística", 6.0);
                Discipline aced = DisciplineGetOrAdd(context, istCSDegree, "Análise Complexa e Equações Diferenciais", 7.5);

                Discipline iei = DisciplineGetOrAdd(context, istCSDegree, "Introdução à Engenharia Informática", 3.0);
                Discipline ges = DisciplineGetOrAdd(context, istCSDegree, "Gestão", 4.5);
                Discipline cs = DisciplineGetOrAdd(context, istCSDegree, "Computação e Sociedade", 3.0);
            }
            #endregion
        }

        private static Project ProjectGetOrAdd(FernandoDbContext context, Discipline discipline, string name, string description)
        {
            Project project = context.Projects.FirstOrDefault(x => x.Name.Equals(name));
            if (project is null)
            {
                project = new Project()
                {
                    Name = name,
                    Description = description,
                    Discipline = discipline,
                    DisciplineId = discipline.Id
                };

                discipline.Project.Add(project);
                context.Disciplines.Update(discipline);

                context.Projects.Add(project);
                context.SaveChanges();
            }
            return project;
        }

        private static Discipline DisciplineGetOrAdd(FernandoDbContext context, Degree degree, string name, double ects, params Skill[] skills)
        {
            Discipline discipline = context.Disciplines.FirstOrDefault(x => x.Name.Equals(name));
            if (discipline is null)
            {
                discipline = new Discipline()
                {
                    Name = name,
                    ECTs = ects,
                    Degree = degree,
                    DegreeId = degree.Id,
                    Skills = skills.ToList()
                };

                degree.Curriculum.Add(discipline);
                context.Degrees.Update(degree);

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
            return discipline;
        }

        private static Degree DegreeGetOrAdd(FernandoDbContext context, string field, EducationLevel level, string institution, DateTime startDate, DateTime endDate, string location)
        {
            Degree degree = context.Degrees.FirstOrDefault(x => x.Field.Equals(field) && x.Level.Equals(level));
            if (degree is null)
            {
                degree = new Degree()
                {
                    Field = field,
                    Level = level,
                    Institution = institution,
                    Location = location,
                    StartDate = startDate,
                    EndTime = endDate
                };

                context.Degrees.Add(degree);
                context.SaveChanges();
            }
            return degree;
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
