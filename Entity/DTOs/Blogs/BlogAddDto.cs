using Entity.DTOs.Categories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Blogs
{
    public class BlogAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }

        [NotMapped] // Veritabanını yansımamasını sağlar
        public IFormFile ImageFile { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
