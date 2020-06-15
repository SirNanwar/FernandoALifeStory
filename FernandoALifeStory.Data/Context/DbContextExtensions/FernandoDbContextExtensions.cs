using FernandoALifeStory.Data.Context.DbContextExtensions.AcademicContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.BookContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.CertificationContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.CourseContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.SkillContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.WorkContext;

namespace FernandoALifeStory.Data.Context.DbContextExtensions
{
    public static class FernandoDbContextExtensions
    {
        public static void EnsureDatabaseSeeded(this FernandoDbContext context)
        {
            SkillContextExtension SkillsContext = new SkillContextExtension()
                                                        .SeedSkills(context);

            BookContextExtension.SeedBooks(context, SkillsContext);
            CertificationContextExtension.SeedCertifications(context, SkillsContext);
            CourseContextExtension.SeedCourses(context, SkillsContext);
            WorkContextExtension.SeedWorkExperiences(context, SkillsContext);
            AcademicContextExtension.SeedAcademics(context, SkillsContext);
        }
    }
}