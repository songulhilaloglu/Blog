using AutoMapper;
using Entity.DTOs.Blogs;
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
    public class BlogController : Controller
    {
        private readonly IBlogService blogService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;
        private readonly IValidator<Blog> validator;

        public BlogController(IBlogService blogService, ICategoryService categoryService, IMapper mapper, IToastNotification toast, IValidator<Blog> validator)
        {
            this.blogService = blogService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.toast = toast;
            this.validator = validator;
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Index()
        {
            var blogs = await blogService.GetAllBlogsAsync();
            return View(blogs);
        }

        // Blog ekleme GET
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesAsync();
            return View(new BlogAddDto { Categories = categories });
        }
        // Blog ekleme POST
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Add(BlogAddDto blogAddDto)
        {
            var map = mapper.Map<Blog>(blogAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await blogService.CreateBlogAsync(blogAddDto);
                toast.AddSuccessToastMessage(Messages.Blog.Add(blogAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Blog", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }
            var categories = await categoryService.GetAllCategoriesAsync();
            return View(new BlogAddDto { Categories = categories });
        }

        // Blog güncelleme GET
        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(int blogId)
        {
            var blog = await blogService.GetBlogAsync(blogId);
            var categories = await categoryService.GetAllCategoriesAsync();
            var blogUpdateDto = mapper.Map<BlogUpdateDto>(blog);
            blogUpdateDto.Categories = categories;
            return View(blogUpdateDto);
        }
        // Blog güncelleme POST
        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Update(BlogUpdateDto blogUpdateDto)
        {
            var map = mapper.Map<Blog>(blogUpdateDto);
            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                var title = await blogService.UpdateBlogAsync(blogUpdateDto);
                toast.AddSuccessToastMessage(Messages.Blog.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Blog", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }
            var categories = await categoryService.GetAllCategoriesAsync();
            blogUpdateDto.Categories = categories;
            return View(blogUpdateDto);
        }

        // Blog silme GET
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Delete(int blogId)
        {
            var title = await blogService.DeleteBlogAsync(blogId);
            toast.AddSuccessToastMessage(Messages.Blog.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Blog", new { Area = "Admin" });
        }
        
    }
}
