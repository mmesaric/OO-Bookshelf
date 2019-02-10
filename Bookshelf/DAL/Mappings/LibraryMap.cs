using FluentNHibernate.Mapping;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mappings
{
    public class LibraryMap : ClassMap<Library>
    {
        public LibraryMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            Map(x => x.TelephoneNumber);
            Map(x => x.WorkingHours);
            HasMany(x => x.Books)
                .Inverse()
                .Cascade.All();
        }
    }
}
