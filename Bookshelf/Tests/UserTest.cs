using DAL;
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
    public class UserTest
    {

        [TestMethod]
        public void TestUser_AddReservedBook()
        {
            User user = new User();
            Book book = new Book();

            user.ReservedBooks.Add(book);

            Assert.AreEqual(1, user.ReservedBooks.Count());
        }

        [TestMethod]
        public void TestUser_AddMultipleReservedBook()
        {
            User user = new User();
            Book book = new Book();
            Book book2 = new Book();

            user.ReservedBooks.Add(book);
            user.ReservedBooks.Add(book2);

            Assert.AreEqual(2, user.ReservedBooks.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestUser_RemoveReservedBook()
        {
            User user = new User();      
            Book book = new Book();

            user.ReservedBooks.Add(book);
            user.ReservedBooks.Remove(book);

            Assert.AreEqual(0, user.ReservedBooks.Count());
        }

        [TestMethod]
        public void TestUser_LoginUser()
        {
            User user = new User
            {
                Username = "testni"
            };
            LoginInfo.Login(user);

            var loggedIn = LoginInfo.GetUser();

            Assert.AreEqual("testni", loggedIn.Username);
            LoginInfo.Logout();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestUser_LogoutAfterLoginUser()
        {
            User user = new User
            {
                Username = "testni"
            };
            LoginInfo.Login(user);
            LoginInfo.Logout();

            var loggedIn = LoginInfo.GetUser();

            var users = loggedIn.Username;
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestUser_UserBeforeLogin()
        {
            User user = new User
            {
                Username = "testni"
            };

            var loggedIn = LoginInfo.GetUser();

            var users = loggedIn.Username;
        }
    }
}
