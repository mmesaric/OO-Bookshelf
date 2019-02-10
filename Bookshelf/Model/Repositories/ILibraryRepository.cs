using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface ILibraryRepository
    {
        Library GetLibraryByID(int libraryID);

        void AddBook(Book book, int libraryID);

        IList<Library> GetLibrariesThatContainBook(Book book);

        IList<Library> GetLibraries();

        Library GetLibraryByNameAndAddress(string name, string address);
    }
}
