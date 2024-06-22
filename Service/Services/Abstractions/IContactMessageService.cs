using Entity.DTOs.ContactMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Abstractions
{
    public interface IContactMessageService
    {
        Task<List<ContactMessageDto>> GetAllContactMessagesAsync();
        Task<ContactMessageDto> GetAllContactMessageAsync(int contactMessageId);
        Task CreateContactMessageAsync(ContactMessageAddDto contactMessageAddDto);
    }
}
