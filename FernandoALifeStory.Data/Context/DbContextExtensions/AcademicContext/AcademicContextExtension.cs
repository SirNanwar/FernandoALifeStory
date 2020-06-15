using FernandoALifeStory.Data.Context.DbContextExtensions.SkillContext;
using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.AcademicContext
{
    static class AcademicContextExtension
    {
        public static void SeedAcademics(FernandoDbContext context, SkillContextExtension skillsContext)
        {
            Degree istCSDegree = DegreeGetOrAdd(context, AcademicNames.LEIC.field, EducationLevel.Bachelor, AcademicNames.LEIC.institution, new DateTime(2014, 09, 09), new DateTime(2018, 07, 10), AcademicNames.LEIC.location);
            if (context.Degrees.Any(x => x.Field.Equals(istCSDegree.Field) && x.Level.Equals(istCSDegree.Level)))
            {
                Discipline fp = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.fp, 7.5, skillsContext.Skills[SkillName.PYTHON]);
                if (context.Disciplines.Any(x => x.Name.Equals(fp.Name)))
                {
                    Project cc = ProjectGetOrAdd(context, fp, AcademicNames.CC.name, AcademicNames.CC.description);
                    Project game2048 = ProjectGetOrAdd(context, fp, AcademicNames.Game2048.name, AcademicNames.Game2048.description);
                }
                Discipline iac = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.iac, 7.5, skillsContext.Skills[SkillName.ASM]);
                if (context.Disciplines.Any(x => x.Name.Equals(iac.Name)))
                {
                    Project tennis = ProjectGetOrAdd(context, iac, AcademicNames.Tennis.name, AcademicNames.Tennis.description);
                }
                Discipline iaed = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.iaed, 7.5, skillsContext.Skills[SkillName.C], skillsContext.Skills[SkillName.ALGORITHM]);
                Discipline lp = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.lp, 7.5, skillsContext.Skills[SkillName.PROLOG], skillsContext.Skills[SkillName.SEARCHALG]);
                if (context.Disciplines.Any(x => x.Name.Equals(lp.Name)))
                {
                    Project puzzle8 = ProjectGetOrAdd(context, lp, AcademicNames.Puzzle8.name, AcademicNames.Puzzle8.description);
                }
                Discipline so = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.so, 6.0, skillsContext.Skills[SkillName.C], skillsContext.Skills[SkillName.ASYNC]);
                if (context.Disciplines.Any(x => x.Name.Equals(so.Name)))
                {
                    Project parshell = ProjectGetOrAdd(context, so, AcademicNames.Parshell.name, AcademicNames.Parshell.description);
                }
                Discipline asa = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.asa, 6.0, skillsContext.Skills[SkillName.C], skillsContext.Skills[SkillName.ALGORITHM], skillsContext.Skills[SkillName.BIGO]);
                if (context.Disciplines.Any(x => x.Name.Equals(asa.Name)))
                {
                    Project fundamentalUsers = ProjectGetOrAdd(context, asa, AcademicNames.FundamentalUser.name, AcademicNames.FundamentalUser.description);
                    Project coelhoECaracol = ProjectGetOrAdd(context, asa, AcademicNames.CoelhoCaracol.name, AcademicNames.CoelhoCaracol.description);
                }
                Discipline ipm = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.ipm, 7.5, skillsContext.Skills[SkillName.HTML], skillsContext.Skills[SkillName.JS]);
                if (context.Disciplines.Any(x => x.Name.Equals(ipm.Name)))
                {
                    Project barista = ProjectGetOrAdd(context, ipm, AcademicNames.Barista.name, AcademicNames.Barista.description);
                }
                Discipline bd = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.bd, 6.0, skillsContext.Skills[SkillName.SQL], skillsContext.Skills[SkillName.RELDB]);
                if (context.Disciplines.Any(x => x.Name.Equals(bd.Name)))
                {
                    Project office = ProjectGetOrAdd(context, bd, AcademicNames.Office.name, AcademicNames.Office.description);
                }
                Discipline cg = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.cg, 4.5, skillsContext.Skills[SkillName.JS]);
                if (context.Disciplines.Any(x => x.Name.Equals(cg.Name)))
                {
                    Project invader = ProjectGetOrAdd(context, cg, AcademicNames.SpaceInvader.name, AcademicNames.SpaceInvader.description);
                }
                Discipline ia = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.ia, 7.5, skillsContext.Skills[SkillName.LISP], skillsContext.Skills[SkillName.SEARCHALG], skillsContext.Skills[SkillName.LEARNALG], skillsContext.Skills[SkillName.KNOWLEDGE]);
                if (context.Disciplines.Any(x => x.Name.Equals(ia.Name)))
                {
                    Project racer = ProjectGetOrAdd(context, ia, AcademicNames.Racetrack.name, AcademicNames.Racetrack.description);
                }
                Discipline oc = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.oc, 6.0, skillsContext.Skills[SkillName.COMPARCH], skillsContext.Skills[SkillName.MEMMANA]);
                Discipline po = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.po, 6.0, skillsContext.Skills[SkillName.JAVA], skillsContext.Skills[SkillName.DP], skillsContext.Skills[SkillName.OOP]);
                if (context.Disciplines.Any(x => x.Name.Equals(po.Name)))
                {
                    Project interpretor = ProjectGetOrAdd(context, po, AcademicNames.Interpretor.name, AcademicNames.Interpretor.description);
                }
                Discipline es = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.es, 7.5, skillsContext.Skills[SkillName.JAVA], skillsContext.Skills[SkillName.JUNIT], skillsContext.Skills[SkillName.JMOCKIT], skillsContext.Skills[SkillName.SPRING], skillsContext.Skills[SkillName.JMETER], skillsContext.Skills[SkillName.MYSQL], skillsContext.Skills[SkillName.UNITTEST], skillsContext.Skills[SkillName.AGILE]);
                if (context.Disciplines.Any(x => x.Name.Equals(es.Name)))
                {
                    Project adventureBuilder = ProjectGetOrAdd(context, es, AcademicNames.Builder.name, AcademicNames.Builder.description);
                }
                Discipline sd = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.sd, 7.5, skillsContext.Skills[SkillName.WEBSERV], skillsContext.Skills[SkillName.CRYPTOG]);
                Discipline rc = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.rc, 6.0, skillsContext.Skills[SkillName.CLOUDCOMP], skillsContext.Skills[SkillName.HTTP]);
                Discipline ams = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.ams, 6.0, skillsContext.Skills[SkillName.UML], skillsContext.Skills[SkillName.ARCHI], skillsContext.Skills[SkillName.BPMN], skillsContext.Skills[SkillName.SYSML]);
                if (context.Disciplines.Any(x => x.Name.Equals(ams.Name)))
                {
                    Project baik = ProjectGetOrAdd(context, ams, AcademicNames.Baik.name, AcademicNames.Baik.description);
                }
                Discipline comp = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.comp, 6.0, skillsContext.Skills[SkillName.CPP]);
                if (context.Disciplines.Any(x => x.Name.Equals(comp.Name)))
                {
                    Project gr8 = ProjectGetOrAdd(context, comp, AcademicNames.Gr8.name, AcademicNames.Gr8.description);
                }

                Discipline al = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.al, 6.0);
                Discipline md = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.md, 7.5);
                Discipline mo = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.mo, 6.0);
                Discipline cdiI = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.cdiI, 6.0);
                Discipline eo = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.eo, 6.0);
                Discipline tc = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.tc, 4.5);
                Discipline cdiII = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.cdiII, 7.5);
                Discipline pe = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.pe, 6.0);
                Discipline aced = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.aced, 7.5);

                Discipline iei = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.iei, 3.0);
                Discipline ges = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.ges, 4.5);
                Discipline cs = DisciplineGetOrAdd(context, istCSDegree, AcademicNames.LEIC_Curriculum.cs, 3.0);
            }
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

                SkillRelationContextExtension.AddSkillRelations(context, discipline, skills);
            }
            discipline.Project ??= new List<Project>();
            return discipline;
        }
    }
}
