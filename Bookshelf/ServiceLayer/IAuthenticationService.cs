using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IAuthenticationService
    {
        bool Authenticate(string username, string password);
        void Logout();
    }
}
