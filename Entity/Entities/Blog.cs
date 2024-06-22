using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entity.Entities
{
    public class Blog : EntityBase
    {
        public Blog()
        {

        }
        public Blog(string title, string content, int userId, string createdBy, int categoryId, int ımageId)
        {
            Title = title;
            Content = content;
            UserId = userId;
            CreatedBy = createdBy;
            CategoryId = categoryId;
            ImageId = ımageId;
            
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }

        public int UserId { get; set; }
        public AppUser User { get; set; }


    }
}
