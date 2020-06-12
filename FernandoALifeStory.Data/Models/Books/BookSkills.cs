using FernandoALifeStory.Data.Models.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.Books
{
    public class BookSkills
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
