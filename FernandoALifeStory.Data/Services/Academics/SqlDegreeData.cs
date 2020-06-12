using FernandoALifeStory.Data.Models.Academics;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FernandoALifeStory.Data.Context;

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
