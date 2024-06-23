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
                         Title = "Hoşgeldiniz ",
                         Subtitle = "Müvekkillerimize en iyi hukuk hizmetini \r\n güvenilir ve hızlı bir şekilde sunmaktayız.",
                         Description = "Ayrıca müvekkillerimize eksiksiz hizmet verebilmek için alanında uzman çeşitli akademisyenler ve mali müşavirlerle de yakın iş birliği içerisindeyiz.",
                         ImageId = 1,
                         CreatedBy = "Songül Hilaloğlu",
                         CreatedDate = DateTime.Now,
                         IsDeleted = false
                     }
                 );
        }
    }
}
