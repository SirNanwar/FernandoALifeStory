using FernandoALifeStory.Data.Models.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Books
{
    public interface IBookSkillData
    {
        IEnumerable<BookSkill> GetAll();
        IEnumerable<BookSkill> GetByBookId(int bookId);
        IEnumerable<BookSkill> GetBySkillId(int skillId);
        BookSkill GetByBookAndSkillIds(int bookId, int skillId);
    }
}
