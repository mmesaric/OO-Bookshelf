using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Book
    {
        public virtual int Id { get; protected set; }
        public virtual BookDetails BookDetails { get; set; }
        public virtual bool IsBorrowed { get; set; }
        public virtual DateTime BorrowedUntil { get; set; }
        public virtual bool IsReserved { get; set; }

        public virtual Library Library { get; set; }
        public virtual User User { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj.GetType() == typeof(Book)))
                return false;
            Book p = (Book)obj;
            return p.BookDetails.Title.Equals(BookDetails.Title) 
                && p.BookDetails.Publisher.Equals(BookDetails.Publisher)
                && p.BookDetails.YearPublished.Equals(BookDetails.YearPublished);
        }

        public override int GetHashCode()
        {
            var hashCode = -479751879;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + BookDetails.Title.GetHashCode();
            hashCode = hashCode * -1521134295 + BookDetails.Publisher.GetHashCode();
            hashCode = hashCode * -1521134295 + BookDetails.YearPublished.GetHashCode();

            return hashCode;
        }
    }


}
