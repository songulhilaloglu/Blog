using Data.UnitOfWorks;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Abstractions;

namespace WEB.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService blogService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUnitOfWork unitOfWork;

        public BlogController(IBlogService blogService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            this.blogService = blogService;
            this.httpContextAccessor = httpContextAccessor;
            this.unitOfWork = unitOfWork;
        }


        // Pagination ile birlikte tüm makaleleri listeler
        [Route("blogs")]
        public async Task<IActionResult> Blog(int? categoryId, int currentPage = 1, int pageSize = 6, bool isAscending = false)
        {
            var blogs = await blogService.GetAllByPagingAsync(categoryId, currentPage, pageSize, isAscending);

            return View(blogs);
        }

        // Blog detayı
        
        public async Task<IActionResult> Detail(int id)
        {
            var ipAddress = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            var blogVisitors = await unitOfWork.GetRepository<BlogVisitor>().GetAllAsync(null, x => x.Visitor, y => y.Blog);
            var blog = await unitOfWork.GetRepository<Blog>().GetAsync(x => x.Id == id);

            var result = await blogService.GetBlogAsync(id);

            var visitor = await unitOfWork.GetRepository<Visitor>().GetAsync(x => x.IpAddress == ipAddress);

            var addBlogVisitors = new BlogVisitor(blog.Id, visitor.Id);

            if (blogVisitors.Any(x => x.VisitorId == addBlogVisitors.VisitorId && x.BlogId == addBlogVisitors.BlogId))
            {
                return View(result);
            }  
            else
            {
                await unitOfWork.GetRepository<BlogVisitor>().AddAsync(addBlogVisitors);
                blog.ViewCount += 1;
                await unitOfWork.GetRepository<Blog>().UpdateAsync(blog);
                await unitOfWork.SaveAsync();
            }

            
            return View(result);
        }
    }
}
