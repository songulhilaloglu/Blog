using AutoMapper;
using Entity.DTOs.ContactMessages;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AutoMapper.ContactMessages
{
    public class ContactMessageProfile : Profile
    {
        public ContactMessageProfile()
        {
            CreateMap<ContactMessageDto, ContactMessage>().ReverseMap();
            CreateMap<ContactMessageAddDto, ContactMessage>().ReverseMap();
        }
    }
}
