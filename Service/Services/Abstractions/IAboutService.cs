using Entity.DTOs.Abouts;
using Entity.DTOs.Blogs;
using Entity.DTOs.Categories;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Abstractions
{
    public interface IAboutService
    {
        Task<List<AboutDto>> GetAllAboutsAsync();
        Task<About> GetAboutByIdAsync(int id);
        Task<string> UpdateAboutAsync(AboutUpdateDto aboutUpdateDto);
        
    }
}
