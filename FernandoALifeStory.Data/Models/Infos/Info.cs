using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Models.Infos
{
    public class Info
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ContactInfo> ContactInformation { get; set; }
        public List<SocialMediaInfo> SocialMedias { get; set; }
    }
}
