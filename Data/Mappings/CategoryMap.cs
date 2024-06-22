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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                (
                    new Category
                    {
                        Id = 1,
                        Name = "Kategori1",
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Kategori2",
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Kategori3",
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false
                    }
                );
        }
    }
}
