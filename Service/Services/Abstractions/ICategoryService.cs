using Entity.DTOs.Categories;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Abstractions
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllCategoriesAsync();
        Task CreateCategoryAsync(CategoryAddDto categoryAddDto);
        Task<Category> GetCategoryByIdAsync(int id);
        Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
        Task<string> DeleteCategoryAsync(int categoryId);
       
    }
}
