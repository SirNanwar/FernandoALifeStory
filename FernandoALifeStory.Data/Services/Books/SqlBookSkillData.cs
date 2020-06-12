using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Services.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Books
{
    public class SqlBookSkillData : IBookSkillData
    {
        private readonly DbSet<BookSkill> bookSkills;

        public SqlBookSkillData(FernandoDbContext db)
        {
            this.bookSkills = db.BookSkills;
        }

        public IEnumerable<BookSkill> GetAll()
        {
            return bookSkills.OrderBy(x => x.BookId);
        }

        public IEnumerable<BookSkill> GetByBookId(int bookId)
        {
            return bookSkills.Where(x => x.BookId == bookId);
        }

        public IEnumerable<BookSkill> GetBySkillId(int skillId)
        {
            return bookSkills.Where(x => x.SkillId == skillId);
        }

        public BookSkill GetByBookAndSkillIds(int bookId, int skillId)
        {
            return bookSkills.FirstOrDefault(x => x.BookId == bookId &&
                                                  x.SkillId == skillId);
        }
    }
}
