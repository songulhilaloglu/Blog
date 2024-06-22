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
    public class ContactMessageMap : IEntityTypeConfiguration<ContactMessage>
    {
        public void Configure(EntityTypeBuilder<ContactMessage> builder)
        {
            builder.HasData
                 (
                     new ContactMessage
                     {
                         Id = 1,
                         FullName = "Songül Hilaloğlu",
                         Email = "songulhilaloglu@hotmail.com",
                         PhoneNumber = "+905335028317",
                         CreatedBy = "Songül Hilaloğlu",
                         Message = "Test mesajıdır, bize ulaşın sayfasındaki mesajlar bu alana yansıyacaktır..",
                         CreatedDate = DateTime.Now,
                         IsDeleted = false
                     }
                 );
        }
    }
}
