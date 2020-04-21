namespace FernandoALifeStory.Data.Models.WorkExperiences
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Work Work { get; set; }
        public int WorkId { get; set; }
    }
}