using FernandoALifeStory.Data.Models.Courses;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Courses
{
    public interface ICourseData
    {
        IEnumerable<Course> GetAll();

        Course GetById(int id);

        IEnumerable<Course> GetCoursesByPlatformId(int id);
    }
}