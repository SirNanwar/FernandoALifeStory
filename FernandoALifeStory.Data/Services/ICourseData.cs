using FernandoALifeStory.Data.Models;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services
{
    public interface ICourseData
    {
        IEnumerable<Course> GetAll();
        Course GetById(int id);
    }
}
