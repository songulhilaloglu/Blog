using AutoMapper;
using Entity.DTOs.Abouts;
using Entity.DTOs.Categories;
using Entity.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Service.Services.Abstractions;
using Service.Services.Concrete;
using System.ComponentModel.DataAnnotations;
using WEB.Consts;
using WEB.ResultMessages;

namespace WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService aboutService;
        private readonly IMapper mapper;
        private readonly IValidator<About> validator;
        private readonly IToastNotification toast;

        public AboutController(IAboutService aboutService, IMapper mapper, IValidator<About> validator, IToastNotification toast)
        {
            this.aboutService = aboutService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Index()
        {
            var abouts = await aboutService.GetAllAboutsAsync();
            return View(abouts);
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(int aboutId)
        {
            var about = await aboutService.GetAboutByIdAsync(aboutId);
            var map = mapper.Map<AboutUpdateDto>(about);
            return View(map);
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(AboutUpdateDto aboutUpdateDto)
        {
            var map = mapper.Map<About>(aboutUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await aboutService.UpdateAboutAsync(aboutUpdateDto);
                toast.AddSuccessToastMessage(Messages.About.Update(name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "About", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }

    }
}
