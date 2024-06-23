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
                        Name = "Ceza Davaları",
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Boşanma ve Nafaka Davaları",
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Trafik Kazalarına Bağlı Maddi ve Manevi Tazminatlar",
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false
                    }
                    ,
                    new Category
                    {
                        Id = 4,
                        Name = "İş Davaları",
                        CreatedBy = "Songül Hilaloğlu",
                        CreatedDate = DateTime.Now,
                        IsDeleted = false
                    }
                );
        }
    }
}
