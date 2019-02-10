using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLib
{
    public interface ILobbyController
    {
        void ViewLobby(ILobbyView lobbyView); 
        void ShowDetails(string title, string publisher, int yearPublished);
        void ShowMakeReservation(string title, string publisher, int yearPublished);
        void ShowViewReservations();
        IList<Book> SearchBooks(String searchText);
    }
}
