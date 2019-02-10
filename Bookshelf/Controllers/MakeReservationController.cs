using BaseLib;
using DAL;
using Model.Entities;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class MakeReservationController : IMakeReservationController
    {
        private IRepositoryFactory _repositoryFactory;

        public MakeReservationController(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public bool MakeReservation(string libraryName, string libraryAddress, Book book, 
            IMakeReservationView makeReservationView)
        {
            var libraryRepository = _repositoryFactory.GetLibraryRepository();
            var userRepository = _repositoryFactory.GetUserRepository();
            var bookRepository = _repositoryFactory.GetBookRepository();

            var user = LoginInfo.GetUser();
            var library = libraryRepository.GetLibraryByNameAndAddress(libraryName, libraryAddress);

            var theBook = 
                library.Books
                .Where(b => b.BookDetails.Title == book.BookDetails.Title &&
                            b.BookDetails.Publisher == book.BookDetails.Publisher &&
                            b.BookDetails.YearPublished == book.BookDetails.YearPublished)
                .FirstOrDefault();

            if (theBook.IsReserved)
            {
                makeReservationView.NotifyOfReservedBook(book);
                return false;
            }

            theBook.IsReserved = true;
            theBook.User = user;
            user.ReservedBooks.Add(theBook);
            bookRepository.Update(book);
            userRepository.Update(user);

            return true;
        }
    }
}
