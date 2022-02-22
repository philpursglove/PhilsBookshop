using System.Collections.Generic;

namespace PhilsBookshop.Web
{
    public interface IBookRepository
    {
        IEnumerable<Book> List();
        Book Get(string ISBN);
        void Update(Book book);
        void Delete(string ISBN);
        void Insert(Book book);
    }
}
