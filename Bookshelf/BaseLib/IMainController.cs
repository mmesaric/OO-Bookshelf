using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLib
{
    public interface IMainController
    {
        bool CheckAuthentication(string username, string password);
        void ShowSearch();
        void Logout();
    }
}
