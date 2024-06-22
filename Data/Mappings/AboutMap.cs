using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings
{
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasData
                 (
                     new About
                     {
                         Id = 1,
                         Title = "Songül Hilaloğlu",
                         Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Etiam sit amet nisl purus in mollis nunc. Facilisi nullam vehicula ipsum a arcu cursus vitae congue mauris. Lacus sed turpis tincidunt id aliquet risus feugiat in. Tortor id aliquet lectus proin nibh nisl condimentum. Mollis aliquam ut porttitor leo. Dis parturient montes nascetur ridiculus. Bibendum enim facilisis gravida neque convallis a cras semper auctor. Turpis egestas maecenas pharetra convallis posuere morbi leo urna molestie. Ut eu sem integer vitae justo. Ut morbi tincidunt augue interdum velit. Ut porttitor leo a diam sollicitudin tempor id eu. Pellentesque dignissim enim sit amet venenatis urna cursus eget.",
                         CreatedBy = "Songül Hilaloğlu",
                         CreatedDate = DateTime.Now,
                         IsDeleted = false 
                     }
                 );
        }
    }
}
