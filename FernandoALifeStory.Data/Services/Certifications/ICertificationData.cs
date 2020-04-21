using FernandoALifeStory.Data.Models.Certifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Certifications
{
    public interface ICertificationData
    {
        IEnumerable<Certification> GetAll();
        Certification GetById(int id);
    }
}
