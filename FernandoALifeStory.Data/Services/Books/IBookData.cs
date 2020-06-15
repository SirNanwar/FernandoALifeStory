using FernandoALifeStory.Data.Models.Books;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.Books
{
    public interface IBookData
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);
    }
}