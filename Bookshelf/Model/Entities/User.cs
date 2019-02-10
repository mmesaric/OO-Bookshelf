using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class User
    {
        public virtual int Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual IList<Book> ReservedBooks { get; protected set; }

        public User()
        {
            ReservedBooks = new List<Book>();
        }

    }
}
