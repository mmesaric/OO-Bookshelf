using FluentNHibernate.Mapping;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class BookDetailsMap : ClassMap<BookDetails>
    {
        public BookDetailsMap()
        {
            Id(x => x.Id);
            Map(x => x.Title);
            Map(x => x.Author);
            Map(x => x.Publisher);
            Map(x => x.YearPublished);
            Map(x => x.Description);
            Map(x => x.Genre);
            HasMany(x => x.Books)
                .Inverse()
                .Cascade.All();
        }
    }
}
