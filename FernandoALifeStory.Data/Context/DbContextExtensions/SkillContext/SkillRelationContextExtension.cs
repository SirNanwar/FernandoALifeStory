using FernandoALifeStory.Data.Context.DbContextExtensions.AcademicContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.BookContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.CertificationContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.CourseContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.WorkContext;
using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using FernandoALifeStory.Data.Models.WorkExperiences;
using System;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.SkillContext
{
    internal static class SkillRelationContextExtension
    {
        public static void AddSkillRelations(FernandoDbContext context, object entry, Skill[] skills)
        {
            switch (entry)
            {
                case Discipline d:
                    AcademicSkillContextExtension.AddDisciplineSkillRelations(context, d, skills);
                    break;

                case Book b:
                    BookSkillContextExtension.AddBookSkillRelations(context, b, skills);
                    break;

                case Certification c:
                    CertificationSkillContextExtension.AddCertificationSkillRelations(context, c, skills);
                    break;

                case Course c:
                    CourseSkillContextExtension.AddCourseSkillRelations(context, c, skills);
                    break;

                case Work w:
                    WorkSkillContextExtension.AddWorkSkillRelations(context, w, skills);
                    break;

                default:
                    throw new ArgumentException();
            }
        }
    }
}