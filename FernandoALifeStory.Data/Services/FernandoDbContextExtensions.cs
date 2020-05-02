using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Courses;
using FernandoALifeStory.Data.Models.Skills;
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
            /*
            Process for courses, replicate to others:
                Books and Certifications will not need the nesting
                Academics will need another level of nesting
                WorkExperiences will be the same

            Create all the needed skills and use in the creation of all the objects that need skills
                
            if Platorfm 1 does not exist
                create platform 1
            if platform 1 exists
                if couse A1 does not exist
                    create couse A1
                if course B1 does not exist
                    create course B1
                (..repeat for other couses from 1..)
            
            if Platorfm 2 does not exist
                create platform 2
            if platform 2 exists
                if couse A2 does not exist
                    create couse A2
                if course B2 does not exist
                    create course B2
                (..repeat for other couses from 2..)
            
            (..Repeat for other platforms..)

            [.....] All the other being made
             */



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
