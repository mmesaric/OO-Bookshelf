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
    public class BookTest
    {
        BookDetails bookDetails;
        public BookTest()
        {
            bookDetails = new BookDetails
            {
                Title = "Moby Dick",
                Author = "Herman Melville",
                Publisher = "Penguin",
                YearPublished = 2001,
                Genre = "Classic",
                Description = "Moby-Dick; or, The Whale is an 1851 novel by American writer Herman Melville. " +
                        "The book is sailor Ishmael's narrative of the obsessive quest of Ahab, captain of the whaling ship Pequod, " +
                        "for revenge on Moby Dick, the white whale that on the ship's previous voyage bit off Ahab's leg at the knee.",
            };
        }

        [TestMethod]
        public void BookTest_CreateBookWithSameDetails_CheckTitle()
        {
            Book book1 = new Book();
            book1.BookDetails = bookDetails;
            Book book2 = new Book();
            book2.BookDetails = bookDetails;

            Assert.AreEqual(book1.BookDetails.Title, book2.BookDetails.Title);
        }

        [TestMethod]
        public void BookTest_CreateBookWithSameDetails_CheckPublisher()
        {
            Book book1 = new Book();
            book1.BookDetails = bookDetails;
            Book book2 = new Book();
            book2.BookDetails = bookDetails;

            Assert.AreEqual(book1.BookDetails.Publisher, book2.BookDetails.Publisher);
        }
    }
}
