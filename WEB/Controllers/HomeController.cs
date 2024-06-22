using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;
using System.Diagnostics;
using WEB.Models;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBannerService bannerService;

        public HomeController(ILogger<HomeController> logger, IBannerService bannerService)
        {
            _logger = logger;
            this.bannerService = bannerService;
        }


        public async Task<IActionResult> Index()
        {
            var banners = await bannerService.GetAllBannersAsync();
            return View(banners);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
