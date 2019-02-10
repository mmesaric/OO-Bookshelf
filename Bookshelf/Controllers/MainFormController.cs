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
    public class MainFormController : IMainController
    {
        private readonly IWindowFormsFactory _formsFactory;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IUserRepository _userRepository;

        public MainFormController(IWindowFormsFactory inFormFactory, IRepositoryFactory repositoryFactory)
        {
            _formsFactory = inFormFactory;
            _repositoryFactory = repositoryFactory;
            _userRepository = _repositoryFactory.GetUserRepository();
        }

        public bool CheckAuthentication(string username, string password)
        {
            var User = _userRepository.GetUserByUsername(username);
            if (User != null)
            {
                if (User.Password == password)
                {
                    LoginInfo.Login(User);
                    return true;
                }
            }

            return false;
        }

        public void Logout()
        {
            LoginInfo.Logout();
        }

        public void ShowSearch()
        {
            var lobbyController = new LobbyController(_formsFactory, _repositoryFactory);
            var lobbyForm = _formsFactory.CreateLobbyView(this, lobbyController);
            lobbyController.ViewLobby(lobbyForm);
        }
    }
}
