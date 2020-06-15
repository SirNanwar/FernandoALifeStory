using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using FernandoALifeStory.Data.Models.WorkExperiences;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.SkillContext
{
    internal class SkillContextExtension
    {
        public Dictionary<string, Skill> Skills { get; set; }

        public SkillContextExtension SeedSkills(FernandoDbContext context) 
        {
            if (Skills is null)
            {
                Skills = new Dictionary<string, Skill>()
                {
                    { SkillName.CSHARP, SkillGetOrAdd(context, SkillName.CSHARP, SkillType.LanguageSkill)},
                    { SkillName.CPP, SkillGetOrAdd(context, SkillName.CPP, SkillType.LanguageSkill)},
                    { SkillName.PYTHON, SkillGetOrAdd(context, SkillName.PYTHON, SkillType.LanguageSkill)},
                    { SkillName.UML, SkillGetOrAdd(context, SkillName.UML, SkillType.LanguageSkill)},
                    { SkillName.ARCHI, SkillGetOrAdd(context, SkillName.ARCHI, SkillType.LanguageSkill)},
                    { SkillName.BPMN, SkillGetOrAdd(context, SkillName.BPMN, SkillType.LanguageSkill)},
                    { SkillName.SYSML, SkillGetOrAdd(context, SkillName.SYSML, SkillType.LanguageSkill)},
                    { SkillName.JAVA, SkillGetOrAdd(context, SkillName.JAVA, SkillType.LanguageSkill)},
                    { SkillName.LISP, SkillGetOrAdd(context, SkillName.LISP, SkillType.LanguageSkill)},
                    { SkillName.JS, SkillGetOrAdd(context, SkillName.JS, SkillType.LanguageSkill)},
                    { SkillName.SQL, SkillGetOrAdd(context, SkillName.SQL, SkillType.LanguageSkill)},
                    { SkillName.HTML, SkillGetOrAdd(context, SkillName.HTML, SkillType.LanguageSkill)},
                    { SkillName.C, SkillGetOrAdd(context, SkillName.C, SkillType.LanguageSkill)},
                    { SkillName.PROLOG, SkillGetOrAdd(context, SkillName.PROLOG, SkillType.LanguageSkill)},
                    { SkillName.ASM, SkillGetOrAdd(context, SkillName.ASM, SkillType.LanguageSkill)},
                    { SkillName.ASPDOTNET, SkillGetOrAdd(context, SkillName.ASPDOTNET, SkillType.TechnologySkill)},
                    { SkillName.DOTNET, SkillGetOrAdd(context, SkillName.DOTNET, SkillType.TechnologySkill)},
                    { SkillName.EFCORE, SkillGetOrAdd(context, SkillName.EFCORE, SkillType.TechnologySkill)},
                    { SkillName.ORM, SkillGetOrAdd(context, SkillName.ORM, SkillType.TechnologySkill)},
                    { SkillName.SQLSERVER, SkillGetOrAdd(context, SkillName.SQLSERVER, SkillType.TechnologySkill)},
                    { SkillName.VS, SkillGetOrAdd(context, SkillName.VS, SkillType.TechnologySkill)},
                    { SkillName.AZURE, SkillGetOrAdd(context, SkillName.AZURE, SkillType.TechnologySkill)},
                    { SkillName.SELENIUM, SkillGetOrAdd(context, SkillName.SELENIUM, SkillType.TechnologySkill)},
                    { SkillName.JUNIT, SkillGetOrAdd(context, SkillName.JUNIT, SkillType.TechnologySkill)},
                    { SkillName.JMOCKIT, SkillGetOrAdd(context, SkillName.JMOCKIT, SkillType.TechnologySkill)},
                    { SkillName.JMETER, SkillGetOrAdd(context, SkillName.JMETER, SkillType.TechnologySkill)},
                    { SkillName.SPRING, SkillGetOrAdd(context, SkillName.SPRING, SkillType.TechnologySkill)},
                    { SkillName.MYSQL, SkillGetOrAdd(context, SkillName.MYSQL, SkillType.TechnologySkill)},
                    { SkillName.MVC, SkillGetOrAdd(context, SkillName.MVC, SkillType.PatternSkill)},
                    { SkillName.DP, SkillGetOrAdd(context, SkillName.DP, SkillType.PatternSkill)},
                    { SkillName.REST, SkillGetOrAdd(context, SkillName.REST, SkillType.PatternSkill)},
                    { SkillName.CLEANCODE, SkillGetOrAdd(context, SkillName.CLEANCODE, SkillType.ConceptSkill)},
                    { SkillName.UNITTEST, SkillGetOrAdd(context, SkillName.UNITTEST, SkillType.ConceptSkill)},
                    { SkillName.AGILE, SkillGetOrAdd(context, SkillName.AGILE, SkillType.ConceptSkill)},
                    { SkillName.AUTOTEST, SkillGetOrAdd(context, SkillName.AUTOTEST, SkillType.ConceptSkill)},
                    { SkillName.VOIP, SkillGetOrAdd(context, SkillName.VOIP, SkillType.ConceptSkill)},
                    { SkillName.CYBERSEC, SkillGetOrAdd(context, SkillName.CYBERSEC, SkillType.ConceptSkill)},
                    { SkillName.CI, SkillGetOrAdd(context, SkillName.CI, SkillType.ConceptSkill)},
                    { SkillName.CLOUDCOMP, SkillGetOrAdd(context, SkillName.CLOUDCOMP, SkillType.ConceptSkill)},
                    { SkillName.HTTP, SkillGetOrAdd(context, SkillName.HTTP, SkillType.ConceptSkill)},
                    { SkillName.WEBSERV, SkillGetOrAdd(context, SkillName.WEBSERV, SkillType.ConceptSkill)},
                    { SkillName.CRYPTOG, SkillGetOrAdd(context, SkillName.CRYPTOG, SkillType.ConceptSkill)},
                    { SkillName.OOP, SkillGetOrAdd(context, SkillName.OOP, SkillType.ConceptSkill)},
                    { SkillName.COMPARCH, SkillGetOrAdd(context, SkillName.COMPARCH, SkillType.ConceptSkill)},
                    { SkillName.MEMMANA, SkillGetOrAdd(context, SkillName.MEMMANA, SkillType.ConceptSkill)},
                    { SkillName.SEARCHALG, SkillGetOrAdd(context, SkillName.SEARCHALG, SkillType.ConceptSkill)},
                    { SkillName.LEARNALG, SkillGetOrAdd(context, SkillName.LEARNALG, SkillType.ConceptSkill)},
                    { SkillName.KNOWLEDGE, SkillGetOrAdd(context, SkillName.KNOWLEDGE, SkillType.ConceptSkill)},
                    { SkillName.RELDB, SkillGetOrAdd(context, SkillName.RELDB, SkillType.ConceptSkill)},
                    { SkillName.ALGORITHM, SkillGetOrAdd(context, SkillName.ALGORITHM, SkillType.ConceptSkill)},
                    { SkillName.BIGO, SkillGetOrAdd(context, SkillName.BIGO, SkillType.ConceptSkill)},
                    { SkillName.ASYNC, SkillGetOrAdd(context, SkillName.ASYNC, SkillType.ConceptSkill)},
                    { SkillName.AUTOMATION, SkillGetOrAdd(context, SkillName.AUTOMATION, SkillType.ConceptSkill)},
                    { SkillName.WEBSCRAP, SkillGetOrAdd(context, SkillName.WEBSCRAP, SkillType.ConceptSkill)}
                };
            }

            return this;
        }

        private static Skill SkillGetOrAdd(FernandoDbContext context, string skillName, SkillType skillType)
        {
            Skill skill = context.Skills.FirstOrDefault(x => x.Name.Equals(skillName) &&
                                                             x.Type == skillType);
            if (skill is null)
            {
                skill = new Skill()
                {
                    Name = skillName,
                    Type = skillType,

                    DisciplineSkills = new List<DisciplineSkill>(),
                    BookSkills = new List<BookSkill>(),
                    CertificationSkills = new List<CertificationSkill>(),
                    CourseSkills = new List<CourseSkill>(),
                    WorkSkills = new List<WorkSkill>()
                };
                context.Skills.Add(skill);
                context.SaveChanges();
            }

            return skill;
        }
    }
}