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
    public class ShowReservationsController : IShowReservationsController
    {
        private IRepositoryFactory _repositoryFactory;
        private IUserRepository _userRepository;
        private IBookRepository _bookRepository;
        
        public ShowReservationsController(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
            _userRepository = _repositoryFactory.GetUserRepository();
            _bookRepository = _repositoryFactory.GetBookRepository();
        }

        public void DeleteReservation(Book book)
        {
            var user = LoginInfo.GetUser();
            user.ReservedBooks.Remove(book);

            book.User = null;
            book.IsReserved = false;

            _bookRepository.Update(book);
            _userRepository.Update(user);
        }
    }
}
