using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
using FernandoALifeStory.Data.Models.WorkExperiences;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace FernandoALifeStory.Data.Services.Context
{
    public class FernandoDbContext : DbContext
    {
        public DbSet<Skill> Skills { get; set; }

        public DbSet<CoursePlatform> CoursePlatforms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSkill> CourseSkills { get; set; }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<DisciplineSkill> DisciplineSkills { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookSkill> BookSkills { get; set; }

        public DbSet<Work> Works { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<WorkSkill> WorkSkills { get; set; }

        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CertificationSkill> CertificationSkills { get; set; }

        public FernandoDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseSkill>().HasKey(cs => new { cs.CourseId, cs.SkillId });
            modelBuilder.Entity<DisciplineSkill>().HasKey(ds => new { ds.DisciplineId, ds.SkillId });
            modelBuilder.Entity<BookSkill>().HasKey(bs => new { bs.BookId, bs.SkillId });
            modelBuilder.Entity<WorkSkill>().HasKey(ws => new { ws.WorkId, ws.SkillId });
            modelBuilder.Entity<CertificationSkill>().HasKey(cs => new { cs.CertificationId, cs.SkillId });
        }
    }
}
