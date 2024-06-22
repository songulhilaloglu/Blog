using AutoMapper;
using Entity.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;
using Service.Services.Concrete;

namespace WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactMessageController : Controller
    {
        private readonly IContactMessageService contactMessageService;
        private readonly IValidator<ContactMessage> validator;
        private readonly IMapper mapper;

        public ContactMessageController(IContactMessageService contactMessageService, IValidator<ContactMessage> validator, IMapper mapper)
        {
            this.contactMessageService = contactMessageService;
            this.validator = validator;
            this.mapper = mapper;
        }
       
        public async Task<IActionResult> Index()
        {
            var contactMessages = await contactMessageService.GetAllContactMessagesAsync();
            return View(contactMessages);
        }

    }
}
