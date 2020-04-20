using FernandoALifeStory.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services
{
    public class CourseDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public CourseDbContext(DbContextOptions options)
            : base (options)
        {

        }
    }
}
