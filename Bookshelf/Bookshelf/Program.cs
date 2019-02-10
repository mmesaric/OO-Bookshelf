using Controllers;
using DAL;
using System;
using PresentationLayer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositories;
using NHibernate;

namespace Bookshelf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ISessionFactory sessionFactory =  NHibernateService.OpenSessionFactory();
            //NHibernateService.

            WindowFormsFactory formsFactory = new WindowFormsFactory();
            IRepositoryFactory repositoryFactory = new RepositoryFactory(sessionFactory);

            MainFormController mainController = new MainFormController(formsFactory, repositoryFactory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainWindow(mainController));
        }
    }
}
