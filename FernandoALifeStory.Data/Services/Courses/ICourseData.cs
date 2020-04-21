using FernandoALifeStory.Data.Models.Courses;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Courses
{
    public interface ICourseData
    {
        IEnumerable<Course> GetAll();
        Course GetById(int id);
    }
}
