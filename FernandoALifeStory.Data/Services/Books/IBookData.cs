using FernandoALifeStory.Data.Models.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace FernandoALifeStory.Data.Services.Books
{
    public interface IBookData
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
    }
}
