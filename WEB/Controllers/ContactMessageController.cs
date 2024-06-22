using AutoMapper;
using Entity.DTOs.ContactMessages;
using Entity.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;

namespace WEB.Controllers
{
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


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var contactMessages = await contactMessageService.GetAllContactMessagesAsync();
            return View(contactMessages);
        }



        [HttpGet]
        [Route("contact-messages")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("contact-messages")]
        public async Task<IActionResult> Add(ContactMessageAddDto contactMessageAddDto)
        {
            var map = mapper.Map<ContactMessage>(contactMessageAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await contactMessageService.CreateContactMessageAsync(contactMessageAddDto);
                TempData["SuccessMessage"] = "Mesajınız başarıyla gönderilmiştir.";
                return RedirectToAction("Add", "ContactMessage");
            }

            else
            {
                result.AddToModelState(ModelState);
                return View("Add", contactMessageAddDto);


            }

        }

    }
}
