using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class BookDetails
    {
        public virtual int Id { get; protected set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual string Publisher { get; set; }
        public virtual int YearPublished { get; set; }
        public virtual string Description { get; set; }
        public virtual string Genre { get; set; }
        public virtual IList<Book> Books { get; set; }

        public BookDetails()
        {
            Books = new List<Book>();
        }
    }
}
