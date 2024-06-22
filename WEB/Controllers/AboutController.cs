using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;
using Service.Services.Concrete;

namespace WEB.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService aboutService;

        public AboutController(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }

        [Route("about")]
        public async Task<IActionResult> Index()
        {
            var abouts = await aboutService.GetAllAboutsAsync();
            return View(abouts);
        }
    }
}
