using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Image : EntityBase
    {
        public Image()
        {
            Blogs = new List<Blog>();
            Users = new HashSet<AppUser>();
        }

        public Image(string fileName, string fileType, string createdBy)
        {
            FileName = fileName;
            FileType = fileType;
            CreatedBy = createdBy;
        }

        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<AppUser> Users { get; set; }
    }
}
