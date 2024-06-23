using AutoMapper;
using Data.UnitOfWorks;
using Entity.DTOs.ContactMessages;
using Entity.Entities;
using Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Concrete
{
    public class ContactMessageService : IContactMessageService
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ContactMessageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task CreateContactMessageAsync(ContactMessageAddDto contactMessageAddDto)
        {
            var contactMessage = new ContactMessage(contactMessageAddDto.FullName, contactMessageAddDto.Email, contactMessageAddDto.PhoneNumber, contactMessageAddDto.Message);
            contactMessage.CreatedDate = DateTime.Now;
            contactMessage.IsDeleted = false;
            await unitOfWork.GetRepository<ContactMessage>().AddAsync(contactMessage);
            await unitOfWork.SaveAsync();
        }

        public async Task<ContactMessageDto> GetAllContactMessageAsync(int contactMessageId)
        {
            var contactMessage = await unitOfWork.GetRepository<ContactMessage>().GetAsync(x => !x.IsDeleted && x.Id == contactMessageId);
            var map = mapper.Map<ContactMessageDto>(contactMessage);
            return map;
        }

        public async Task<List<ContactMessageDto>> GetAllContactMessagesAsync()
        {

            var contactMessages = await unitOfWork.GetRepository<ContactMessage>().GetAllAsync();
            var map = mapper.Map<List<ContactMessageDto>>(contactMessages);
            return map;
        }
    }
}
