using Entity.DTOs.Abouts;
using Entity.DTOs.Banners;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Abstractions
{
    public interface IBannerService
    {
        Task<List<BannerDto>> GetAllBannersAsync();
        Task<Banner> GetBannerByIdAsync(int id);
        Task<string> UpdateBannerAsync(BannerUpdateDto bannerUpdateDto);
        
        
    }
}
