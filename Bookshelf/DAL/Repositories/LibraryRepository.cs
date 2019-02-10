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
    public class LibraryRepository : ILibraryRepository
    {
        private ISession _currSession;

        public LibraryRepository(ISession session)
        {
            _currSession = session;
        }

        public void AddBook(Book book, int libraryID)
        {
            GetLibraryByID(libraryID).Books.Add(book);
        }

        public IList<Library> GetLibraries()
        {
            return _currSession
                .Query<Library>()
                .ToList();
        }

        public IList<Library> GetLibrariesThatContainBook(Book book)
        {
            return _currSession
                .Query<Library>()
                .Where(p => p.Books.Contains(book))
                .ToList();
        }

        public Library GetLibraryByID(int libraryID)
        {
            return _currSession.Get<Library>(libraryID);
        }

        public Library GetLibraryByNameAndAddress(string name, string address)
        {
            return _currSession
                .Query<Library>()
                .Where(library => library.Name == name && library.Address == address)
                .FirstOrDefault();             
        }
    }
}
