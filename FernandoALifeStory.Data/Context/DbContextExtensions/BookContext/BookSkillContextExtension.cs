using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Skills;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.BookContext
{
    internal static class BookSkillContextExtension
    {
        public static void AddBookSkillRelations(FernandoDbContext context, Book book, Skill[] skills)
        {
            foreach (Skill skill in skills)
            {
                BookSkill bookSkill = new BookSkill()
                {
                    BookId = book.Id,
                    Book = book,
                    SkillId = skill.Id,
                    Skill = skill
                };

                book.BookSkills.Add(bookSkill);
                skill.BookSkills.Add(bookSkill);

                context.BookSkills.Add(bookSkill);

                context.Books.Update(book);
                context.Skills.Update(skill);
            }

            context.SaveChanges();
        }
    }
}