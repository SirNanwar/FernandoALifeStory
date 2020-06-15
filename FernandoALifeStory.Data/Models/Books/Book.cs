using System.Collections.Generic;

namespace FernandoALifeStory.Data.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public List<BookSkill> BookSkills { get; set; }
    }
}