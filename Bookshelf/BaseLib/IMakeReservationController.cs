using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IMakeReservationController
    {
        bool MakeReservation(string libraryName, string libraryAddress, Book book, IMakeReservationView makeReservationView);
    }
}
