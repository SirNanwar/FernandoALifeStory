using FernandoALifeStory.Data.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Books
{
    public class SqlBookData : IBookData
    {
        private readonly FernandoDbContext db;

        public SqlBookData(FernandoDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Book> GetAll()
        {
            return db.Books.OrderBy(x => x.Name);
        }

        public Book GetById(int id)
        {
            return db.Books.FirstOrDefault(x => x.Id == id);
        }
    }
}
