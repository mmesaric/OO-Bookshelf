using System;
using DAL.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Model.Entities;
using System.IO;

namespace DAL
{

    using global::NHibernate;
    using global::NHibernate.Cfg;
    using global::NHibernate.Tool.hbm2ddl;
    using System.Collections.Generic;

    public class NHibernateService
    {
        private static ISessionFactory _sessionFactory;


        public static ISession OpenSession()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = OpenSessionFactory();
                }
                ISession session = _sessionFactory.OpenSession();
                return session;
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }
        }

        public static ISessionFactory OpenSessionFactory()
        {
            try
            {
                _sessionFactory = Fluently.Configure()
                   .Database(SQLiteConfiguration.Standard
                   .ConnectionString("Data Source=bookshelfdb.db;Version=3")
                   //.UsingFile("C:/sqlite/sqlite-tools-win32-x86-3260000/bookshelfdb.db")
                   )
                   .Mappings(m => m.FluentMappings.Add<BookMap>())
                   .Mappings(m => m.FluentMappings.Add<UserMap>())
                   .Mappings(m => m.FluentMappings.Add<LibraryMap>())
                   .Mappings(m => m.FluentMappings.Add<BookDetailsMap>())
                   //.ExposeConfiguration(BuildSchema)
                   .BuildSessionFactory();

                //InitialPopulate();
            }
            catch (Exception)
            {
                throw;
            }

            return _sessionFactory;
        }

        private static void BuildSchema(Configuration config)
        {
            // delete the existing db on each run
            if (File.Exists("C:/sqlite/sqlite-tools-win32-x86-3260000/bookshelfdb.db"))
                File.Delete("C:/sqlite/sqlite-tools-win32-x86-3260000/bookshelfdb.db");

            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaExport(config)
              .Create(false, true);
        }

        private static void InitialPopulate()
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var BookDetailsMobyDick = new BookDetails
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

                    var BookDetailsMobyDick2 = new BookDetails
                    {
                        Title = "Moby Dick",
                        Author = "Herman Melville",
                        Publisher = "Alfa",
                        YearPublished = 1998,
                        Genre = "Classic",
                        Description = "Moby-Dick; or, The Whale is an 1851 novel by American writer Herman Melville. " +
                        "The book is sailor Ishmael's narrative of the obsessive quest of Ahab, captain of the whaling ship Pequod, " +
                        "for revenge on Moby Dick, the white whale that on the ship's previous voyage bit off Ahab's leg at the knee.",
                    };

                    var BookDetailsMobyDick3 = new BookDetails
                    {
                        Title = "Moby Dick",
                        Author = "Herman Melville",
                        Publisher = "Penguin",
                        YearPublished = 2002,
                        Genre = "Classic",
                        Description = "Moby-Dick; or, The Whale is an 1851 novel by American writer Herman Melville. " +
                        "The book is sailor Ishmael's narrative of the obsessive quest of Ahab, captain of the whaling ship Pequod, " +
                        "for revenge on Moby Dick, the white whale that on the ship's previous voyage bit off Ahab's leg at the knee.",
                    };

                    var ConanBookDetails = new BookDetails
                    {
                        Title = "The Complete Chronicles of Conan",
                        Author = "Robert E. Howard",
                        Publisher = "Gollancz",
                        YearPublished = 2009,
                        Genre = "Sword and sorcery",
                        Description = "Conan the Barbarian: born on a battlefield in Cimmeria, his life was " +
                        "spent wandering the world of the legendary Hyborian Age. From boy-thief to pirate, " +
                        "mercenary and outlaw, ultimately becoming King of Aquilonia, Conan carved a red swathe" +
                        " through lost cities and unexplored jungles, facing hideous horrors or supernatural menaces" +
                        " with nothing more than a sharp sword in his hand and a beautiful woman at his side. "
                    };

                    var LibraryStaglisce = new Library
                    {
                        Name = "Staglišće",
                        Address = "Jarun 5, 10000 Zagreb",
                        TelephoneNumber = "013529242",
                        WorkingHours = "8-20"
                    };
                    var LibraryPrecko = new Library
                    {
                        Name = "Prečko",
                        Address = "Prečko 5, 10000 Zagreb",
                        TelephoneNumber = "013519548",
                        WorkingHours = "8-20"
                    };

                    var MobyDick = new Book
                    {
                        BookDetails = BookDetailsMobyDick,
                        IsBorrowed = false,
                        Library = LibraryPrecko
                    };

                    var MobyDick2 = new Book
                    {
                        BookDetails = BookDetailsMobyDick,
                        IsBorrowed = false,
                        Library = LibraryStaglisce
                    };

                    var MobyDick3 = new Book
                    {
                        BookDetails = BookDetailsMobyDick2,
                        IsBorrowed = false,
                        Library = LibraryStaglisce
                    };

                    var MobyDick4 = new Book
                    {
                        BookDetails = BookDetailsMobyDick3,
                        IsBorrowed = false,
                        Library = LibraryStaglisce
                    };

                    var Conan = new Book
                    {
                        BookDetails = ConanBookDetails,
                        IsBorrowed = false,
                        Library = LibraryPrecko
                    };

                    var UserMarko = new User { FirstName = "Marko", LastName = "Surname", Username = "marko", Password = "marko" };
                    var UserLuka = new User { FirstName = "Luka", LastName = "Surname", Username = "luka", Password = "luka" };


                    session.SaveOrUpdate(BookDetailsMobyDick);
                    session.SaveOrUpdate(BookDetailsMobyDick2);
                    session.SaveOrUpdate(BookDetailsMobyDick3);
                    session.SaveOrUpdate(ConanBookDetails);
                    session.SaveOrUpdate(LibraryStaglisce);
                    session.SaveOrUpdate(LibraryPrecko);
                    session.SaveOrUpdate(MobyDick);
                    session.SaveOrUpdate(MobyDick2);
                    session.SaveOrUpdate(MobyDick3);
                    session.SaveOrUpdate(MobyDick4);
                    session.SaveOrUpdate(Conan);
                    session.SaveOrUpdate(UserMarko);
                    session.SaveOrUpdate(UserLuka);

                    transaction.Commit();
                }
            }
        }
    }
}
