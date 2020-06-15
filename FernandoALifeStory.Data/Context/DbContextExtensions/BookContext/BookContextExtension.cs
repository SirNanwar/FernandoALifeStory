using FernandoALifeStory.Data.Context.DbContextExtensions.SkillContext;
using FernandoALifeStory.Data.Models.Books;
using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Context.DbContextExtensions.BookContext
{
    static class BookContextExtension
    {
        public static void SeedBooks(FernandoDbContext context, SkillContextExtension skillsContext)
        {
            Book cleanCodeBook = BookGetOrAdd(context,
                                              "Clean Code",
                                              "Robert C. Martin",
                                              "A Handbook of Agile Software Craftsmanship",
                                              skillsContext.Skills[SkillName.DP],
                                              skillsContext.Skills[SkillName.CLEANCODE],
                                              skillsContext.Skills[SkillName.UNITTEST],
                                              skillsContext.Skills[SkillName.AGILE]);
        }

        private static Book BookGetOrAdd(FernandoDbContext context,  string name, string author, string description, params Skill[] skills)
        {
            Book book = context.Books.FirstOrDefault(x => x.Name.Equals(name));
            if (book is null)
            {
                book = new Book()
                {
                    Name = name,
                    AuthorName = author,
                    Description = description,
                    BookSkills = new List<BookSkill>()
                };

                context.Books.Add(book);
                context.SaveChanges();

                SkillRelationContextExtension.AddSkillRelations(context, book, skills);
            }
            return book;
        }
    }
}
