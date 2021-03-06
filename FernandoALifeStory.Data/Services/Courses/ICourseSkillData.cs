﻿using FernandoALifeStory.Data.Models.Courses;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Courses
{
    public interface ICourseSkillData
    {
        IEnumerable<CourseSkill> GetAll();

        IEnumerable<CourseSkill> GetByCourseId(int courseId);

        IEnumerable<CourseSkill> GetBySkillId(int skillId);

        CourseSkill GetByCourseAndSkillIds(int courseId, int skillId);
    }
}