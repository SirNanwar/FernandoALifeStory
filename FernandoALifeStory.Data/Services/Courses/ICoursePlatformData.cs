using FernandoALifeStory.Data.Models.Courses;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Courses
{
    public interface ICoursePlatformData
    {
        IEnumerable<CoursePlatform> GetAll();

        CoursePlatform GetById(int id);
    }
}