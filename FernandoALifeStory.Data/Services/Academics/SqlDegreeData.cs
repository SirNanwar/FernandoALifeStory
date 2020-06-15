using FernandoALifeStory.Data.Context;
using FernandoALifeStory.Data.Models.Academics;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Services.Academics
{
    public class SqlDegreeData : IDegreeData
    {
        private readonly DbSet<Degree> degrees;

        public SqlDegreeData(FernandoDbContext db)
        {
            this.degrees = db.Degrees;
        }

        public IEnumerable<Degree> GetAll()
        {
            return degrees.OrderBy(x => x.StartDate);
        }

        public Degree GetById(int id)
        {
            return degrees.FirstOrDefault(x => x.Id == id);
        }
    }
}