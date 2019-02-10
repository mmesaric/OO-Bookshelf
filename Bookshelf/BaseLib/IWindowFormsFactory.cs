using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLib
{
    public interface IWindowFormsFactory
    {
        ILobbyView CreateLobbyView(IMainController mainController, ILobbyController lobbyController);
        ISearchResultsView CreateSearchResultsView(IMainController mainController, ISearchResultsController searchResultsController);
        IBookDetailsView CreateBookDetailsView(IBookDetailsController bookDetailsController);
        IMakeReservationView CreateMakeReservationView(IMakeReservationController makeReservationController);
        IShowReservationsView CreateShowReservationsView(IShowReservationsController showReservationsController);
    }
}
