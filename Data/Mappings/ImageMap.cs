using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;

namespace Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
            new Image
            {
                Id = 1,
                FileName = "blog-images/default.jpg",
                FileType = "jpg",
                CreatedBy = "Songül Hilaloğlu",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }
            
            );
        }
    }
}
