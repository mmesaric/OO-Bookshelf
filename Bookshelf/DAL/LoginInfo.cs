using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginInfo
    {
        private static User _user;

        public static void Login(User user)
        {
            if (_user == null)
            {
                _user = user;
            }
        }

        public static User GetUser()
        {
            return _user;
        }

        public static void Logout()
        {
            _user = null;
        }
    }
}
