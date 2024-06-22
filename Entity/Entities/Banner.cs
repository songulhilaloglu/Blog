using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entity.Entities
{
    public class Banner : EntityBase
    {
        public Banner()
        {

        }

        public Banner(string title, string subtitle, string description, int imageId)
        {
            Title = title;
            Subtitle = subtitle;
            Description = description;
            ImageId = imageId;
        }

        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public int? ImageId { get; set; }
        public Image Image { get; set; }
       
    }
}
