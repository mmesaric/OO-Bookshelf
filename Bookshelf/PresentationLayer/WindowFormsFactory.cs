using BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class WindowFormsFactory : IWindowFormsFactory
    {

        public ILobbyView CreateLobbyView(IMainController mainController, ILobbyController lobbyController)
        {
            return new frmLobby(mainController, lobbyController);
        }

        public ISearchResultsView CreateSearchResultsView(IMainController mainController, ISearchResultsController searchResultsController)
        {
            throw new NotImplementedException();
        }

        public IBookDetailsView CreateBookDetailsView(IBookDetailsController bookDetailsController)
        {
            return new frmBookDetails(bookDetailsController);
        }

        public IMakeReservationView CreateMakeReservationView(IMakeReservationController makeReservationController)
        {
            return new frmMakeReservation(makeReservationController);
        }

        public IShowReservationsView CreateShowReservationsView(IShowReservationsController showReservationsController)
        {
            return new frmShowReservations(showReservationsController);
        }
    }
}
