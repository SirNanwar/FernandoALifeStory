namespace FernandoALifeStory.Data.Models.Infos
{
    public class SocialMediaInfo
    {
        public int Id { get; set; }
        public SocialMediaType SocialMediaType { get; set; }
        public string SocialMediaUrl { get; set; }
        public Info Info { get; set; }
        public int InfoId { get; set; }
    }
}