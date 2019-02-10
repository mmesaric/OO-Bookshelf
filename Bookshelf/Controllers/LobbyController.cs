using BaseLib;
using DAL;
using Model.Entities;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class LobbyController : ILobbyController
    {
        private readonly IWindowFormsFactory _formsFactory;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IBookRepository _bookRepository;
        private readonly ILibraryRepository _libraryRepository;


        public LobbyController(IWindowFormsFactory formsFactory, IRepositoryFactory repositoryFactory)
        {
            _formsFactory = formsFactory;
            _repositoryFactory = repositoryFactory;
            _bookRepository = _repositoryFactory.GetBookRepository();
            _libraryRepository = _repositoryFactory.GetLibraryRepository();
        }

        public void ViewLobby(ILobbyView lobbyView)
        {
            var loggedInUser = LoginInfo.GetUser();
            lobbyView.ShowModaless(loggedInUser.FirstName);
        }

        public IList<Book> SearchBooks(string searchText)
        {
            return _bookRepository.GetBooksByName(searchText);
        }

        public void ShowDetails(string title, string publisher, int yearPublished)
        {
            Book book = _bookRepository.GetBookByTitlePublisherYearPublished(title, publisher, yearPublished);
            var detailsController = new BookDetailsController();
            var form = _formsFactory.CreateBookDetailsView(detailsController);

            form.ShowModaless(book);
        }

        public void ShowMakeReservation(string title, string publisher, int yearPublished)
        {
            Book book = _bookRepository.GetBookByTitlePublisherYearPublished(title, publisher, yearPublished);

            IList<Library> allLibraries = _libraryRepository.GetLibraries();
            IList<Library> libraries = new List<Library>();

            foreach (Library library in allLibraries)
            {
                int numberOfBooks = library.Books
                    .Where(b =>               b.BookDetails.Title == title 
                                              && b.BookDetails.Publisher == publisher 
                                              && b.BookDetails.YearPublished == yearPublished)
                    .Count();

                if (numberOfBooks > 0) libraries.Add(library);
            }

            var reservationController = new MakeReservationController(_repositoryFactory);
            var form = _formsFactory.CreateMakeReservationView(reservationController);

            form.ShowModaless(libraries, book);
        }

        public void ShowViewReservations()
        {
            var user = LoginInfo.GetUser();
            IList<Book> books = user.ReservedBooks;

            var controller = new ShowReservationsController(_repositoryFactory);

            var form = _formsFactory.CreateShowReservationsView(controller);
            form.showModaless(books);
        }
    }
}
