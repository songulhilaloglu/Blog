using AutoMapper;
using Data.UnitOfWorks;
using Entity.DTOs.Abouts;
using Entity.DTOs.Banners;
using Entity.Entities;
using Entity.Enums;
using Microsoft.AspNetCore.Http;
using Service.Extensions;
using Service.Helpers;
using Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Concrete
{
    public class BannerService : IBannerService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IImageHelper imageHelper;
        public BannerService(IUnitOfWork unitOfWork, IMapper mapper, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.imageHelper = imageHelper;
        }

        public async Task<List<BannerDto>> GetAllBannersAsync()
        {

            var banners = await unitOfWork.GetRepository<Banner>().GetAllAsync(x => !x.IsDeleted, i => i.Image);

            var map = mapper.Map<List<BannerDto>>(banners);
            return map;
        }

        public async Task<Banner> GetBannerByIdAsync(int id)
        {
            var banner = await unitOfWork.GetRepository<Banner>().GetByIdAsync(id);
            return banner;
        }

        public async Task<string> UpdateBannerAsync(BannerUpdateDto bannerUpdateDto)
        {
            var banner = await unitOfWork.GetRepository<Banner>().GetAsync(x => !x.IsDeleted && x.Id == bannerUpdateDto.Id);
            banner.Title = bannerUpdateDto.Title;
            banner.Subtitle = bannerUpdateDto.Subtitle;
            banner.Description = bannerUpdateDto.Description;
            banner.ModifiedDate = DateTime.Now;
            await unitOfWork.GetRepository<Banner>().UpdateAsync(banner);
            await unitOfWork.SaveAsync();
            return banner.Title;
        }
    }
}
