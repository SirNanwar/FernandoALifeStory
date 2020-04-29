using FernandoALifeStory.Data.Models.Books;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FernandoALifeStory.Data.Services.Books
{
    public class SqlBookData : IBookData
    {
        private readonly DbSet<Book> books;

        public SqlBookData(FernandoDbContext db)
        {
            this.books = db.Books;
        }

        public IEnumerable<Book> GetAll()
        {
            return books.OrderBy(x => x.Name);
        }

        public Book GetById(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
    }
}
