using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IBookRepository
    {
        IList<Book> GetBooksByName(String searchText);
        Book GetBookByTitlePublisherYearPublished(string title, string publisher, int yearPublished);
        void Update(Book book);
    }
}
