using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;
using Service.Services.Concrete;
using WEB.Models;

namespace WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public HomeController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<IActionResult> Index()
        {
            var (totalBlogCount, totalCategoryCount, totalContactMessageCount, totalUserCount) = await _dashboardService.GetDashboardCounts();

            var viewModel = new DashboardViewModel
            {
                TotalBlogCount = totalBlogCount,
                TotalCategoryCount = totalCategoryCount,
                TotalContactMessageCount = totalContactMessageCount,
                TotalUserCount = totalUserCount
            };

            return View(viewModel);
        }
    }
}
