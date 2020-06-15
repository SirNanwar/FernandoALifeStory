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
            Degree istCSDegree = DegreeGetOrAdd(context, "Computer Science and Engineering", EducationLevel.Bachelor, "Instituto Superior Técnico", new DateTime(2014, 09, 09), new DateTime(2018, 07, 10), "Lisbon - Portugal");
            if (context.Degrees.Any(x => x.Field.Equals(istCSDegree.Field) && x.Level.Equals(istCSDegree.Level)))
            {
                Discipline fp = DisciplineGetOrAdd(context, istCSDegree, "Fundamentos da programação", 7.5, skillsContext.Skills[SkillName.PYTHON]);
                if (context.Disciplines.Any(x => x.Name.Equals(fp.Name)))
                {
                    Project cc = ProjectGetOrAdd(context, fp, "Credic Card Generator", "Create a card generator.");
                    Project game2048 = ProjectGetOrAdd(context, fp, "2048 Game", "Create a version of the game 2048.");
                }
                Discipline iac = DisciplineGetOrAdd(context, istCSDegree, "Introdução à Arquitectura de Computadores", 7.5, skillsContext.Skills[SkillName.ASM]);
                if (context.Disciplines.Any(x => x.Name.Equals(iac.Name)))
                {
                    Project tennis = ProjectGetOrAdd(context, iac, "RoboTenis", "Develop a game of tennis in assembly language");
                }
                Discipline iaed = DisciplineGetOrAdd(context, istCSDegree, "Introdução aos Algoritmos e Estruturas de Dados", 7.5, skillsContext.Skills[SkillName.C], skillsContext.Skills[SkillName.ALGORITHM]);
                Discipline lp = DisciplineGetOrAdd(context, istCSDegree, "Lógica para Programação", 7.5, skillsContext.Skills[SkillName.PROLOG], skillsContext.Skills[SkillName.SEARCHALG]);
                if (context.Disciplines.Any(x => x.Name.Equals(lp.Name)))
                {
                    Project puzzle8 = ProjectGetOrAdd(context, lp, "Puzzle of 8", "Develop a version of puzzle of 8 game, and solving algorithms");
                }
                Discipline so = DisciplineGetOrAdd(context, istCSDegree, "Sistemas Operativos", 6.0, skillsContext.Skills[SkillName.C], skillsContext.Skills[SkillName.ASYNC]);
                if (context.Disciplines.Any(x => x.Name.Equals(so.Name)))
                {
                    Project parshell = ProjectGetOrAdd(context, so, "Par-Shell", "Develop asynchronous proggramming practices on a fibonacci number calculator.");
                }
                Discipline asa = DisciplineGetOrAdd(context, istCSDegree, "Análise e Síntese de Algoritmos", 6.0, skillsContext.Skills[SkillName.C], skillsContext.Skills[SkillName.ALGORITHM], skillsContext.Skills[SkillName.BIGO]);
                if (context.Disciplines.Any(x => x.Name.Equals(asa.Name)))
                {
                    Project fundamentalUsers = ProjectGetOrAdd(context, asa, "Fundamental Users", "Develop an algorith to find the fundamental users in a communication network.");
                    Project coelhoECaracol = ProjectGetOrAdd(context, asa, "Coelho&Caracol", "Develop an algorith to find the most efficient path in a graph transversal");
                }
                Discipline ipm = DisciplineGetOrAdd(context, istCSDegree, "Interfaces Pessoa Máquina", 7.5, skillsContext.Skills[SkillName.HTML], skillsContext.Skills[SkillName.JS]);
                if (context.Disciplines.Any(x => x.Name.Equals(ipm.Name)))
                {
                    Project barista = ProjectGetOrAdd(context, ipm, "BarISTa", "Develop an application to simulate a smart bar table");
                }
                Discipline bd = DisciplineGetOrAdd(context, istCSDegree, "Bases de Dados", 6.0, skillsContext.Skills[SkillName.SQL], skillsContext.Skills[SkillName.RELDB]);
                if (context.Disciplines.Any(x => x.Name.Equals(bd.Name)))
                {
                    Project office = ProjectGetOrAdd(context, bd, "Instant Office", "Create a database model for an application");
                }
                Discipline cg = DisciplineGetOrAdd(context, istCSDegree, "Computação Gráfica", 4.5, skillsContext.Skills[SkillName.JS]);
                if (context.Disciplines.Any(x => x.Name.Equals(cg.Name)))
                {
                    Project invader = ProjectGetOrAdd(context, cg, "Space Invader", "Create a 3d version of the game Space Invaders");
                }
                Discipline ia = DisciplineGetOrAdd(context, istCSDegree, "Inteligência Artificial", 7.5, skillsContext.Skills[SkillName.LISP], skillsContext.Skills[SkillName.SEARCHALG], skillsContext.Skills[SkillName.LEARNALG], skillsContext.Skills[SkillName.KNOWLEDGE]);
                if (context.Disciplines.Any(x => x.Name.Equals(ia.Name)))
                {
                    Project racer = ProjectGetOrAdd(context, ia, "Racetrack", "Create an agent to play Racetrack autonomously");
                }
                Discipline oc = DisciplineGetOrAdd(context, istCSDegree, "Organização de Computadores", 6.0, skillsContext.Skills[SkillName.COMPARCH], skillsContext.Skills[SkillName.MEMMANA]);
                Discipline po = DisciplineGetOrAdd(context, istCSDegree, "Programação com Objectos", 6.0, skillsContext.Skills[SkillName.JAVA], skillsContext.Skills[SkillName.DP], skillsContext.Skills[SkillName.OOP]);
                if (context.Disciplines.Any(x => x.Name.Equals(po.Name)))
                {
                    Project interpretor = ProjectGetOrAdd(context, po, "Program Interpretor", "Create a program to manage a set of programs and expressions");
                }
                Discipline es = DisciplineGetOrAdd(context, istCSDegree, "Engenharia de Software", 7.5, skillsContext.Skills[SkillName.JAVA], skillsContext.Skills[SkillName.JUNIT], skillsContext.Skills[SkillName.JMOCKIT], skillsContext.Skills[SkillName.SPRING], skillsContext.Skills[SkillName.JMETER], skillsContext.Skills[SkillName.MYSQL], skillsContext.Skills[SkillName.UNITTEST], skillsContext.Skills[SkillName.AGILE]);
                if (context.Disciplines.Any(x => x.Name.Equals(es.Name)))
                {
                    Project adventureBuilder = ProjectGetOrAdd(context, es, "Adventure Builder", "Leisure activity offer system");
                }
                Discipline sd = DisciplineGetOrAdd(context, istCSDegree, "Sistemas Distribuídos", 7.5, skillsContext.Skills[SkillName.WEBSERV], skillsContext.Skills[SkillName.CRYPTOG]);
                Discipline rc = DisciplineGetOrAdd(context, istCSDegree, "Redes de Computadores", 6.0, skillsContext.Skills[SkillName.CLOUDCOMP], skillsContext.Skills[SkillName.HTTP]);
                Discipline ams = DisciplineGetOrAdd(context, istCSDegree, "Análise e Modelação de Sistemas", 6.0, skillsContext.Skills[SkillName.UML], skillsContext.Skills[SkillName.ARCHI], skillsContext.Skills[SkillName.BPMN], skillsContext.Skills[SkillName.SYSML]);
                if (context.Disciplines.Any(x => x.Name.Equals(ams.Name)))
                {
                    Project baik = ProjectGetOrAdd(context, ams, "BAIK", "Bicicle sharing business model");
                }
                Discipline comp = DisciplineGetOrAdd(context, istCSDegree, "Compiladores", 6.0, skillsContext.Skills[SkillName.CPP]);
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
