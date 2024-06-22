using AutoMapper;
using Entity.DTOs.Abouts;
using Entity.DTOs.Banners;
using Entity.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Service.Services.Abstractions;
using Service.Services.Concrete;
using System.ComponentModel.DataAnnotations;
using WEB.ResultMessages;

namespace WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly IBannerService bannerService;
        private readonly IMapper mapper;
        private readonly IValidator<Banner> validator;
        private readonly IToastNotification toast;

        public BannerController(IBannerService bannerService, IMapper mapper, IValidator<Banner> validator, IToastNotification toast)
        {
            this.bannerService = bannerService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }
        public async Task<IActionResult> Index()
        {
            var banners = await bannerService.GetAllBannersAsync();
            return View(banners);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int bannerId)
        {
            var banner = await bannerService.GetBannerByIdAsync(bannerId);
            var map = mapper.Map<BannerUpdateDto>(banner);
            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Update(BannerUpdateDto bannerUpdateDto)
        {
            var map = mapper.Map<Banner>(bannerUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await bannerService.UpdateBannerAsync(bannerUpdateDto);
                toast.AddSuccessToastMessage(Messages.Banner.Update(name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Banner", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }
    }
}
