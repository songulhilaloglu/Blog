using AutoMapper;
using Data.UnitOfWorks;
using Entity.DTOs.Abouts;
using Entity.DTOs.Banners;
using Entity.DTOs.Blogs;
using Entity.DTOs.Categories;
using Entity.Entities;
using Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Concrete
{
    public class AboutService : IAboutService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public AboutService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<AboutDto>> GetAllAboutsAsync()
        {
            var abouts = await unitOfWork.GetRepository<About>().GetAllAsync();
            var map = mapper.Map<List<AboutDto>>(abouts);
            return map;
        }


        public async Task<About> GetAboutByIdAsync(int id)
        {
            var about = await unitOfWork.GetRepository<About>().GetByIdAsync(id);
            return about;
        }

        public async Task<string> UpdateAboutAsync(AboutUpdateDto aboutUpdateDto)
        {
            var about = await unitOfWork.GetRepository<About>().GetAsync(x => !x.IsDeleted && x.Id == aboutUpdateDto.Id);
            about.Title = aboutUpdateDto.Title;
            about.Content = aboutUpdateDto.Content;
            about.ModifiedDate = DateTime.Now;
            await unitOfWork.GetRepository<About>().UpdateAsync(about);
            await unitOfWork.SaveAsync();
            return about.Title;

        }
    }
}
