using DAL.Repositories;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class AuthenticationService : IAuthenticationService
    {
        private IUserRepository _userRepository;

        public AuthenticationService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Authenticate(string username, string password)
        {
            var User = _userRepository.GetUserByUsername(username);
            if (User != null)
            {
                if (User.Username == username) return true;
            }

            return false;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}