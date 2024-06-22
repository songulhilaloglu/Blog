using AutoMapper;
using Entity.DTOs.Abouts;
using Entity.DTOs.Blogs;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper.Abouts
{
    public class AboutProfile : Profile
    {
        public AboutProfile()
        {
            CreateMap<AboutDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();
        }
    }
}
