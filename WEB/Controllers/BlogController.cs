using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;

namespace WEB.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService blogService;

        public BlogController(IBlogService blogService)
        {
            this.blogService = blogService;
        }


        // Pagination ile birlikte tüm makaleleri listeler
        [Route("blogs")]
        public async Task<IActionResult> Blog(int? categoryId, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            var blogs = await blogService.GetAllByPagingAsync(categoryId, currentPage, pageSize, isAscending);

            return View(blogs);
        }

        // Blog detayı
        public async Task<IActionResult> Detail(int id)
        {

            var blog = await blogService.GetBlogAsync(id);
            return View(blog);
        }
    }
}
