using FernandoALifeStory.Data.Models.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Courses
{
    public interface ICoursePlatformData
    {
        IEnumerable<CoursePlatform> GetAll();
        CoursePlatform GetById(int id);
    }
}
