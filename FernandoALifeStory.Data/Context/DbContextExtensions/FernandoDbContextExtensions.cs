using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Context.DbContextExtensions.AcademicContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.BookContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.CertificationContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.CourseContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.SkillContext;
using FernandoALifeStory.Data.Context.DbContextExtensions.WorkContext;
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

            BookContextExtension.SeedBooks(context, SkillsContext);

            CertificationContextExtension.SeedCertifications(context, SkillsContext);

            CourseContextExtension.SeedCourses(context, SkillsContext);

            WorkContextExtension.SeedWorkExperiences(context, SkillsContext);

            AcademicContextExtension.SeedAcademics(context, SkillsContext);
        }
    }
}
