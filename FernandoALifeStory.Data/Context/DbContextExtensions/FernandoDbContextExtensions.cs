using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using FernandoALifeStory.Data.Models.WorkExperiences;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Context.DbContextExtensions
{
    public static class FernandoDbContextExtensions
    {
        public static void EnsureDatabaseSeeded(this FernandoDbContext context)
        {
            #region Skills
            SkillContextExtension SkillsContext = new SkillContextExtension(context);
            #endregion

            #region Books
            SeedBooks(context, SkillsContext.Skills);
            #endregion

            #region Certifications

            #endregion

            #region Courses
            SeedCourses(context, aspDotNetSkill, mvcSkill, dotNETSkill, cSharpSkill, designPatternsSkill, entityFrameworkCoreSkill, ormSkill, pythonSkill, webscrapingSkill, automationSkill);
            #endregion

            #region Work Experiences
            SeedWorkExperiences(context, dotNETSkill, cSharpSkill, entityFrameworkCoreSkill, ormSkill, unitTestingSkill, agileMethodologiesSkill, automatedTestingSkill, restAPISkill, voipSkill, cyberSecuritySkill, continuousIntegrationSkill, cPPSkill, sQLServerSkill, visualStudioSkill, azureDevOpsSkill, seleniumSkill);
            #endregion

            #region Academics
            SeedAcademics(context, designPatternsSkill, unitTestingSkill, agileMethodologiesSkill, cPPSkill, pythonSkill, uMLSkill, archimateSkill, bPMNSkill, sysMLSkill, cloudComputingSkill, hTTPProtocolSkill, webServicesSkill, cryptographySkill, javaSkill, jUnitSkill, jMockitSkill, jMeterSkill, springBootSkill, mySQLSkill, oOPSkill, computerArquitectureSkill, memoryManagementSkill, lispSkill, searchAlgorithmSkill, learningAlgorithmSkill, knowledgeRepresentationAndReasoningSkill, javascriptSkill, sQLSkill, relationalDatabaseSkill, hTMLSkill, cSkill, algorithmSkill, bigONotationSkill, asynchronousProggrammingSkill, prologSkill, assemblySkill);
            #endregion
        }

        private static void SeedAcademics(FernandoDbContext context, Skill designPatternsSkill, Skill unitTestingSkill, Skill agileMethodologiesSkill, Skill cPPSkill, Skill pythonSkill, Skill uMLSkill, Skill archimateSkill, Skill bPMNSkill, Skill sysMLSkill, Skill cloudComputingSkill, Skill hTTPProtocolSkill, Skill webServicesSkill, Skill cryptographySkill, Skill javaSkill, Skill jUnitSkill, Skill jMockitSkill, Skill jMeterSkill, Skill springBootSkill, Skill mySQLSkill, Skill oOPSkill, Skill computerArquitectureSkill, Skill memoryManagementSkill, Skill lispSkill, Skill searchAlgorithmSkill, Skill learningAlgorithmSkill, Skill knowledgeRepresentationAndReasoningSkill, Skill javascriptSkill, Skill sQLSkill, Skill relationalDatabaseSkill, Skill hTMLSkill, Skill cSkill, Skill algorithmSkill, Skill bigONotationSkill, Skill asynchronousProggrammingSkill, Skill prologSkill, Skill assemblySkill)
        {
            Degree istCSDegree = DegreeGetOrAdd(context, "Computer Science and Engineering", EducationLevel.Bachelor, "Instituto Superior Técnico", new DateTime(2014, 09, 09), new DateTime(2018, 07, 10), "Lisbon - Portugal");
            if (context.Degrees.Any(x => x.Field.Equals(istCSDegree.Field) && x.Level.Equals(istCSDegree.Level)))
            {
                Discipline fp = DisciplineGetOrAdd(context, istCSDegree, "Fundamentos da programação", 7.5, pythonSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(fp.Name)))
                {
                    Project cc = ProjectGetOrAdd(context, fp, "Credic Card Generator", "Create a card generator.");
                    Project game2048 = ProjectGetOrAdd(context, fp, "2048 Game", "Create a version of the game 2048.");
                }
                Discipline iac = DisciplineGetOrAdd(context, istCSDegree, "Introdução à Arquitectura de Computadores", 7.5, assemblySkill);
                if (context.Disciplines.Any(x => x.Name.Equals(iac.Name)))
                {
                    Project tennis = ProjectGetOrAdd(context, iac, "RoboTenis", "Develop a game of tennis in assembly language");
                }
                Discipline iaed = DisciplineGetOrAdd(context, istCSDegree, "Introdução aos Algoritmos e Estruturas de Dados", 7.5, cSkill, algorithmSkill);
                Discipline lp = DisciplineGetOrAdd(context, istCSDegree, "Lógica para Programação", 7.5, prologSkill, searchAlgorithmSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(lp.Name)))
                {
                    Project puzzle8 = ProjectGetOrAdd(context, lp, "Puzzle of 8", "Develop a version of puzzle of 8 game, and solving algorithms");
                }
                Discipline so = DisciplineGetOrAdd(context, istCSDegree, "Sistemas Operativos", 6.0, cSkill, asynchronousProggrammingSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(so.Name)))
                {
                    Project parshell = ProjectGetOrAdd(context, so, "Par-Shell", "Develop asynchronous proggramming practices on a fibonacci number calculator.");
                }
                Discipline asa = DisciplineGetOrAdd(context, istCSDegree, "Análise e Síntese de Algoritmos", 6.0, cSkill, algorithmSkill, bigONotationSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(asa.Name)))
                {
                    Project fundamentalUsers = ProjectGetOrAdd(context, asa, "Fundamental Users", "Develop an algorith to find the fundamental users in a communication network.");
                    Project coelhoECaracol = ProjectGetOrAdd(context, asa, "Coelho&Caracol", "Develop an algorith to find the most efficient path in a graph transversal");
                }
                Discipline ipm = DisciplineGetOrAdd(context, istCSDegree, "Interfaces Pessoa Máquina", 7.5, hTMLSkill, javascriptSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(ipm.Name)))
                {
                    Project barista = ProjectGetOrAdd(context, ipm, "BarISTa", "Develop an application to simulate a smart bar table");
                }
                Discipline bd = DisciplineGetOrAdd(context, istCSDegree, "Bases de Dados", 6.0, sQLSkill, relationalDatabaseSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(bd.Name)))
                {
                    Project office = ProjectGetOrAdd(context, bd, "Instant Office", "Create a database model for an application");
                }
                Discipline cg = DisciplineGetOrAdd(context, istCSDegree, "Computação Gráfica", 4.5, javascriptSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(cg.Name)))
                {
                    Project invader = ProjectGetOrAdd(context, cg, "Space Invader", "Create a 3d version of the game Space Invaders");
                }
                Discipline ia = DisciplineGetOrAdd(context, istCSDegree, "Inteligência Artificial", 7.5, lispSkill, searchAlgorithmSkill, learningAlgorithmSkill, knowledgeRepresentationAndReasoningSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(ia.Name)))
                {
                    Project racer = ProjectGetOrAdd(context, ia, "Racetrack", "Create an agent to play Racetrack autonomously");
                }
                Discipline oc = DisciplineGetOrAdd(context, istCSDegree, "Organização de Computadores", 6.0, computerArquitectureSkill, memoryManagementSkill);
                Discipline po = DisciplineGetOrAdd(context, istCSDegree, "Programação com Objectos", 6.0, javaSkill, designPatternsSkill, oOPSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(po.Name)))
                {
                    Project interpretor = ProjectGetOrAdd(context, po, "Program Interpretor", "Create a program to manage a set of programs and expressions");
                }
                Discipline es = DisciplineGetOrAdd(context, istCSDegree, "Engenharia de Software", 7.5, javaSkill, jUnitSkill, jMockitSkill, springBootSkill, jMeterSkill, mySQLSkill, unitTestingSkill, agileMethodologiesSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(es.Name)))
                {
                    Project adventureBuilder = ProjectGetOrAdd(context, es, "Adventure Builder", "Leisure activity offer system");
                }
                Discipline sd = DisciplineGetOrAdd(context, istCSDegree, "Sistemas Distribuídos", 7.5, webServicesSkill, cryptographySkill);
                Discipline rc = DisciplineGetOrAdd(context, istCSDegree, "Redes de Computadores", 6.0, cloudComputingSkill, hTTPProtocolSkill);
                Discipline ams = DisciplineGetOrAdd(context, istCSDegree, "Análise e Modelação de Sistemas", 6.0, uMLSkill, archimateSkill, bPMNSkill, sysMLSkill);
                if (context.Disciplines.Any(x => x.Name.Equals(ams.Name)))
                {
                    Project baik = ProjectGetOrAdd(context, ams, "BAIK", "Bicicle sharing business model");
                }
                Discipline comp = DisciplineGetOrAdd(context, istCSDegree, "Compiladores", 6.0, cPPSkill);
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
        }

        private static void SeedWorkExperiences(FernandoDbContext context, Skill dotNETSkill, Skill cSharpSkill, Skill entityFrameworkCoreSkill, Skill ormSkill, Skill unitTestingSkill, Skill agileMethodologiesSkill, Skill automatedTestingSkill, Skill restAPISkill, Skill voipSkill, Skill cyberSecuritySkill, Skill continuousIntegrationSkill, Skill cPPSkill, Skill sQLServerSkill, Skill visualStudioSkill, Skill azureDevOpsSkill, Skill seleniumSkill)
        {
            Work collabWork = WorkExperienceGetOrAdd(context, "Collab", "Software Engineer", new DateTime(2018, 08, 10), null,
                dotNETSkill, cSharpSkill, entityFrameworkCoreSkill, ormSkill,
                unitTestingSkill, agileMethodologiesSkill, automatedTestingSkill, restAPISkill,
                voipSkill, cyberSecuritySkill, continuousIntegrationSkill, cPPSkill,
                sQLServerSkill, visualStudioSkill, azureDevOpsSkill, seleniumSkill);
            if (context.Works.Any(x => x.CompanyName.Equals(collabWork.CompanyName)))
            {
                Achievement microsservice = AchievementGetOrAdd(context, collabWork, "Developed a microservice REST API of asynchronous messaging with Entity Framework Core.");
                Achievement encryption = AchievementGetOrAdd(context, collabWork, "Implemented real time encryption of RTP video calls. ");
                Achievement autoTest = AchievementGetOrAdd(context, collabWork, "Guaranteed product continuous integration, developing integration and functional automated testing.");
                Achievement sipDev = AchievementGetOrAdd(context, collabWork, "Worked on developing SIP solutions for VoIP calls. ");
            }
        }

        private static void SeedBooks(FernandoDbContext context, Dictionary<string, Skill> skillDic)
        {
            Book cleanCodeBook = BookGetOrAdd(context, 
                                              "Clean Code", 
                                              "Robert C. Martin", 
                                              "A Handbook of Agile Software Craftsmanship", 
                                                skillDic[SkillName.DP], 
                                                skillDic[SkillName.CLEANCODE], 
                                                skillDic[SkillName.UNITTEST], 
                                                skillDic[SkillName.AGILE]);
        }

        private static void SeedCourses(FernandoDbContext context, Skill aspDotNetSkill, Skill mvcSkill, Skill dotNETSkill, Skill cSharpSkill, Skill designPatternsSkill, Skill entityFrameworkCoreSkill, Skill ormSkill, Skill pythonSkill, Skill webscrapingSkill, Skill automationSkill)
        {
            CoursePlatform pluralsightPlatform = CoursePlatformGetOrAdd(context, "Pluralsight");
            if (context.CoursePlatforms.Any(x => x.Name.Equals(pluralsightPlatform.Name)))
            {
                Course aspDotNetMVCFundamentals = CourseGetOrAdd(context, pluralsightPlatform, "ASP.NET MVC 5 Fundamentals", "Fundamentals to ASP.NET MVC", aspDotNetSkill, mvcSkill, dotNETSkill, cSharpSkill);
                Course entityFrameworkCore2GettingStarted = CourseGetOrAdd(context, pluralsightPlatform, "Entity Framework Core 2: Getting Started", "First introduction to Entity Framework Core 2, a Microsot O/RM", dotNETSkill, cSharpSkill, entityFrameworkCoreSkill, ormSkill);
                Course cSharpFundamentals = CourseGetOrAdd(context, pluralsightPlatform, "C# Fundamentals", "Fundamentals to C# programming", dotNETSkill, cSharpSkill);
            }

            CoursePlatform udemyPlatform = CoursePlatformGetOrAdd(context, "Udemy");
            if (context.CoursePlatforms.Any(x => x.Name.Equals(udemyPlatform.Name)))
            {
                Course designPatternsInCSharp = CourseGetOrAdd(context, udemyPlatform, "Design Patterns in C# and .NET", "A comprehensive overview of Design Patterns in C# and .NET from a practical perspective.", dotNETSkill, cSharpSkill, designPatternsSkill);
                Course automateTheBoringStuffWithPython = CourseGetOrAdd(context, udemyPlatform, "Automate the Boring Stuff with Python Programming", "If you're an office worker, student, administrator, or just want to become more productive with your computer, programming will allow you write code that can automate tedious tasks. This course follows the popular (and free!) book, Automate the Boring Stuff with Python.", pythonSkill, webscrapingSkill, automationSkill);
            }
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
                    DisciplineSkills = new List<DisciplineSkill>()
                };

                degree.Curriculum.Add(discipline);
                context.Degrees.Update(degree);

                context.Disciplines.Add(discipline);
                context.SaveChanges();

                AddSkillRelations(context, discipline, skills);
            }
            discipline.Project ??= new List<Project>();
            return discipline;
        }

        private static void AddSkillRelations(FernandoDbContext context, object entry, Skill[] skills)
        {
            switch (entry)
            {
                case Discipline d:
                    AddDisciplineSkillRelations(context, d, skills);
                    break;
                case Book b:
                    AddBookSkillRelations(context, b, skills);
                    break;
                case Certification c:
                    AddCertificationSkillRelations(context, c, skills);
                    break;
                case Course c:
                    AddCourseSkillRelations(context, c, skills);
                    break;
                case Work w:
                    AddWorkSkillRelations(context, w, skills);
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private static void AddDisciplineSkillRelations(FernandoDbContext context, Discipline discipline, Skill[] skills)
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

        private static void AddBookSkillRelations(FernandoDbContext context, Book book, Skill[] skills)
        {
            foreach (Skill skill in skills)
            {
                BookSkill bookSkill = new BookSkill()
                {
                    BookId = book.Id,
                    Book = book,
                    SkillId = skill.Id,
                    Skill = skill
                };

                book.BookSkills.Add(bookSkill);
                skill.BookSkills.Add(bookSkill);

                context.BookSkills.Add(bookSkill);

                context.Books.Update(book);
                context.Skills.Update(skill);
            }

            context.SaveChanges();
        }

        private static void AddCertificationSkillRelations(FernandoDbContext context, Certification certification, Skill[] skills)
        {
            foreach (Skill skill in skills)
            {
                CertificationSkill certificationSkill = new CertificationSkill()
                {
                    CertificationId = certification.Id,
                    Certification = certification,
                    SkillId = skill.Id,
                    Skill = skill
                };

                certification.CertificationSkills.Add(certificationSkill);
                skill.CertificationSkills.Add(certificationSkill);

                context.CertificationSkills.Add(certificationSkill);

                context.Certifications.Update(certification);
                context.Skills.Update(skill);
            }

            context.SaveChanges();
        }

        private static void AddCourseSkillRelations(FernandoDbContext context, Course course, Skill[] skills)
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

        private static void AddWorkSkillRelations(FernandoDbContext context, Work w, Skill[] skills)
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
            degree.Curriculum ??= new List<Discipline>();
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

                AddSkillRelations(context, work, skills);
            }
            work.Achievements ??= new List<Achievement>();
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
                    BookSkills = new List<BookSkill>()
                };

                context.Books.Add(book);
                context.SaveChanges();

                AddSkillRelations(context, book, skills);
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

                AddSkillRelations(context, course, skills);
            }

            return course;
        }


    }
}
