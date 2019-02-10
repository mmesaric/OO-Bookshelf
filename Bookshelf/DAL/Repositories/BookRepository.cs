using Model.Entities;
using Model.Repositories;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private ISession _currSession;

        public BookRepository(ISession session)
        {
            _currSession = session;
        }

        public Book GetBookByTitlePublisherYearPublished(string title, string publisher, int yearPublished)
        {
            return _currSession
                .Query<Book>()
                .FirstOrDefault(book => book.BookDetails.Title == title && book.BookDetails.Publisher == publisher
                                && book.BookDetails.YearPublished == yearPublished);
        }

        public IList<Book> GetBooksByName(String searchText)
        {
            return _currSession.Query<Book>()
                .ToList()
                .Where(book => book.BookDetails.Title.Contains(searchText.Trim()))
                .ToList();
        }

        public void Update(Book book)
        {
            using (var transaction = _currSession.BeginTransaction())
            {
                _currSession.SaveOrUpdate(book);

                transaction.Commit();
            }
        }
    }
}
