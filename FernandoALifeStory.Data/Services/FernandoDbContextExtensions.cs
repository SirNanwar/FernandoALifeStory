using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services
{
    public static class FernandoDbContextExtensions
    {
        public static void EnsureDatabaseSeeded(this FernandoDbContext context)
        {
            if (!context.CoursePlatforms.Any())
            {
                context.CoursePlatforms.AddRange(new CoursePlatform()
                {
                    Name = "Pluralsight"
                });
                context.SaveChanges();
            }
            if (!context.Courses.Any())
            {
                var platform1 = context.CoursePlatforms.SingleOrDefault(x => x.Id == 1);

                context.Courses.AddRange(new Course() 
                { 
                    CourseName = "ASP.NET MVC 5 Fundamentals",
                    CoursePlatformId = platform1.Id,
                    CoursePlatform = platform1,
                    Description = "Fundamentals for ASP.NET MVC 5",
                });
                context.SaveChanges();
            }
        }
    }
}
