using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ServiceFactory : IServiceFactory
    {
        IRepositoryFactory _factory;

        public ServiceFactory(RepositoryFactory repositoryFactory)
        {
            _factory = repositoryFactory;
        }

    }
}
