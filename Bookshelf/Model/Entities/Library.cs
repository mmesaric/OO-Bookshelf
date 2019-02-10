using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Library
    {
        public virtual int Id { get; protected set; }   
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string TelephoneNumber { get; set; }
        public virtual string WorkingHours { get; set; }
        public virtual IList<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }
    }
}
