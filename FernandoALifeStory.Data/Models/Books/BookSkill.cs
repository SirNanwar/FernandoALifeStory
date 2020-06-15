using FernandoALifeStory.Data.Models.Skills;

namespace FernandoALifeStory.Data.Models.Books
{
    public class BookSkill
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}