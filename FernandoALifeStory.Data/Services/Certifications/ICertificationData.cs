using FernandoALifeStory.Data.Models.Certifications;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Certifications
{
    public interface ICertificationData
    {
        IEnumerable<Certification> GetAll();

        Certification GetById(int id);
    }
}