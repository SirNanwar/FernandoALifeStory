namespace FernandoALifeStory.Data.Models.Infos
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public ContactType ContactType { get; set; }
        public string Contact { get; set; }
        public Info Info { get; set; }
        public int InfoId { get; set; }
    }
}