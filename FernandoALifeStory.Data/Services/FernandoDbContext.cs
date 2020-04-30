﻿using FernandoALifeStory.Data.Models.Academics;
using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Certifications;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.WorkExperiences;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace FernandoALifeStory.Data.Services
{
    public class FernandoDbContext : DbContext
    {
        public DbSet<CoursePlatform> CoursePlatforms { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Work> WorkExperiences { get; set; }
        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Certification> Certifications { get; set; }

        public FernandoDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
