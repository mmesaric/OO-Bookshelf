using FluentNHibernate.Mapping;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mappings
{
    public class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            Id(x => x.Id);
            References(x => x.BookDetails);
            Map(x => x.IsBorrowed);
            Map(x => x.BorrowedUntil);
            Map(x => x.IsReserved);
            References(x => x.Library);
            References(x => x.User).Cascade.All();
        }
    }
}
