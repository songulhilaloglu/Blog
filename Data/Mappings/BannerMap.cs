using Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings
{
    public class BannerMap : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.HasData
                 (
                     new Banner
                     {
                         Id = 1,
                         Title = "Dermatoloji Uzmanı :",
                         Subtitle = "Working Tirlessly\r\nToward Successful Resolutions",
                         Description = "LOREM IPSUM IS SIMPLY DUMMY TEXT OF THE PRINTING AND TYPESETTING\r\nINDUSTRY. LOREM IPSUM HAS BEEN THE INDUSTRY'S STANDARD DUMMY TEXT\r\nEVER SINCE THE 1500S,",
                         ImageId = 1,
                         CreatedBy = "Songül Hilaloğlu",
                         CreatedDate = DateTime.Now,
                         IsDeleted = false
                     }
                 );
        }
    }
}
