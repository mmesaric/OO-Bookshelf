using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class LibraryTest
    {
        [TestMethod]
        public void TestLibrary_AddBookToLibrary()
        {
            Library library = new Library();
            Book book = new Book();

            library.Books.Add(book);

            Assert.AreEqual(1, library.Books.Count());
        }

        [TestMethod]
        public void TestLibrary_AddMultipleBooksToLibrary()
        {
            Library library = new Library();
            Book book = new Book();
            Book book2 = new Book();
            Book book3 = new Book();

            library.Books.Add(book);
            library.Books.Add(book2);
            library.Books.Add(book3);

            Assert.AreEqual(3, library.Books.Count());
        }

        [TestMethod]
        public void TestLibrary_AddBookTo2Libraries()
        {
            Library library = new Library();
            Library library2 = new Library();

            Book book = new Book();

            library.Books.Add(book);
            library2.Books.Add(book);

            Assert.AreEqual(1, library.Books.Count());

        }
    }
}
