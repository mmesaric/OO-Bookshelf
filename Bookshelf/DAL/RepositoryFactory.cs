using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using NHibernate;

namespace DAL
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private ISessionFactory _sessionFactory;
        private ISession session;
        

        public RepositoryFactory(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
            session = _sessionFactory.OpenSession();
        }

        public LibraryRepository GetLibraryRepository()
        {
            //return new LibraryRepository(_sessionFactory.OpenSession());
            return new LibraryRepository(session);

        }

        public UserRepository GetUserRepository()
        {
            return new UserRepository(session);
        }

        public BookRepository GetBookRepository()
        {
            return new BookRepository(session);
        }
    }
}
