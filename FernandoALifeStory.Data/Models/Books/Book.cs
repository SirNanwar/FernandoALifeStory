using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
