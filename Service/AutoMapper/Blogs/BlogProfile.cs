using AutoMapper;
using Entity.DTOs.Blogs;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper.Blogs
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<BlogDto, Blog>().ReverseMap();
            CreateMap<BlogUpdateDto, Blog>().ReverseMap();
            CreateMap<BlogUpdateDto, BlogDto>().ReverseMap();
            CreateMap<BlogAddDto, Blog>().ReverseMap();
        }
    }
}
