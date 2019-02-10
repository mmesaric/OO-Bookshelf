using FluentNHibernate.Mapping;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Username);
            Map(x => x.Password);
            HasMany(x => x.ReservedBooks)
                .Inverse()
                .Cascade.All();
        }

    }
}
