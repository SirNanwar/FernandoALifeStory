namespace FernandoALifeStory.Data.Models.Academics
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Discipline Discipline { get; set; }
        public int DisciplineId { get; set; }
    }
}