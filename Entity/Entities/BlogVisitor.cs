using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class BlogVisitor : IEntityBase
    {
        public BlogVisitor()
        {
            
        }

        public BlogVisitor(int blogId, int visitorId)
        {
            BlogId = blogId;
            VisitorId = visitorId;
            
        }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
