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
    public class BlogVisitorMap : IEntityTypeConfiguration<BlogVisitor>
    {
        public void Configure(EntityTypeBuilder<BlogVisitor> builder)
        {
            builder.HasKey(x => new { x.BlogId, x.VisitorId });
        }
    }
}
