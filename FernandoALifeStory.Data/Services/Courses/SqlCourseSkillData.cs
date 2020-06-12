using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.Courses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Courses
{
    public class SqlCourseSkillData : ICourseSkillData
    {
        private readonly DbSet<CourseSkill> courseSkills;

        public SqlCourseSkillData(FernandoDbContext db)
        {
            this.courseSkills = db.CourseSkills;
        }

        public IEnumerable<CourseSkill> GetAll()
        {
            return courseSkills.OrderBy(x => x.CourseId);
        }

        public IEnumerable<CourseSkill> GetByCourseId(int courseId)
        {
            return courseSkills.Where(x => x.CourseId == courseId);
        }

        public IEnumerable<CourseSkill> GetBySkillId(int skillId)
        {
            return courseSkills.Where(x => x.SkillId == skillId);
        }

        public CourseSkill GetByCourseAndSkillIds(int courseId, int skillId)
        {
            return courseSkills.FirstOrDefault(x => x.CourseId == courseId &&
                                                    x.SkillId == skillId);
        }
    }
}
