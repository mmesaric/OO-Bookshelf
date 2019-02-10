using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IMakeReservationView
    {
        void ShowModaless(IList<Library> libraries, Book book);
        void NotifyOfReservedBook(Book book);
    }
}
