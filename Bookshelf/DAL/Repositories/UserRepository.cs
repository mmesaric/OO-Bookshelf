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
    public class UserRepository : IUserRepository
    {
        private ISession _currSession;

        public UserRepository(ISession session)
        {
            _currSession = session;
        }

        public User GetUserByID(int userID)
        {
            return _currSession.Get<User>(userID);
        }

        public User GetUserByUsername(string username)
        {
            return  _currSession.Query<User>().FirstOrDefault(p => p.Username == username);
        }

        public void Update(User user)
        {
            using (var transaction = _currSession.BeginTransaction())
            {
                _currSession.SaveOrUpdate(user);

                transaction.Commit();
            }
        }
    }
}
