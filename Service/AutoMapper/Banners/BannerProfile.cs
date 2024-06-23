using AutoMapper;
using Entity.DTOs.Abouts;
using Entity.DTOs.Banners;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper.Banners
{
    public class BannerProfile : Profile
    {
        public BannerProfile()
        {
            CreateMap<BannerDto, Banner>().ReverseMap();
            CreateMap<BannerUpdateDto, Banner>().ReverseMap();
        }
    }
}
