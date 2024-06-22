using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entity.Entities
{
    public class AppUser : IdentityUser<int>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int ImageId { get; set; } 
        public Image Image { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
