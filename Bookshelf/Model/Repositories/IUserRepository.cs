using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IUserRepository
    {
        User GetUserByID(int userID);

        User GetUserByUsername(string username);

        void Update(User user);
    }
}
