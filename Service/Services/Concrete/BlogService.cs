using AutoMapper;
using Data.UnitOfWorks;
using Entity.DTOs.Blogs;
using Entity.Entities;
using Entity.Enums;
using Microsoft.AspNetCore.Http;
using Service.Extensions;
using Service.Helpers;
using Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Concrete
{
    public class BlogService : IBlogService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public BlogService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            this.imageHelper = imageHelper;
        }

        public async Task<BlogListDto> GetAllByPagingAsync(int? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            var Blogs = categoryId == null
                ? await unitOfWork.GetRepository<Blog>().GetAllAsync(a => !a.IsDeleted, a => a.Category, i => i.Image, u => u.User)
                : await unitOfWork.GetRepository<Blog>().GetAllAsync(a => a.CategoryId == categoryId && !a.IsDeleted,
                    a => a.Category, i => i.Image, u => u.User);
            var sortedBlogs = isAscending
                ? Blogs.OrderBy(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                : Blogs.OrderByDescending(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new BlogListDto
            {
                Blogs = sortedBlogs,
                CategoryId = categoryId == null ? null : categoryId.Value,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = Blogs.Count,
                IsAscending = isAscending
            };
        }
        public async Task<List<BlogDto>> GetAllBlogsAsync()
        {

            var blogs = await unitOfWork.GetRepository<Blog>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<BlogDto>>(blogs);
            return map;
        }

        
        public async Task<BlogDto> GetBlogAsync(int BlogId)
        {
            var Blog = await unitOfWork.GetRepository<Blog>().GetAsync(x => !x.IsDeleted && x.Id == BlogId, x => x.Category, i => i.Image, u => u.User);
            var map = mapper.Map<BlogDto>(Blog);
            return map;
        }

        public async Task CreateBlogAsync(BlogAddDto blogAddDto)
        {
            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();
            var imageUpload = await imageHelper.Upload(blogAddDto.Title, blogAddDto.ImageFile, ImageType.Blog);
            Image image = new Image(imageUpload.FullName, blogAddDto.ImageFile.ContentType, userEmail);
            await unitOfWork.GetRepository<Image>().AddAsync(image);
            await unitOfWork.SaveAsync();
            var blog = new Blog(blogAddDto.Title, blogAddDto.Content, userId, userEmail, blogAddDto.CategoryId, image.Id);
            await unitOfWork.GetRepository<Blog>().AddAsync(blog);
            await unitOfWork.SaveAsync(); 
        }

        public async Task<string> UpdateBlogAsync(BlogUpdateDto blogUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var blog = await unitOfWork.GetRepository<Blog>().GetAsync(x => !x.IsDeleted && x.Id == blogUpdateDto.Id, x => x.Category, i => i.Image);

            if (blogUpdateDto.ImageFile != null)
            {
                imageHelper.Delete(blog.Image.FileName);

                var imageUpload = await imageHelper.Upload(blogUpdateDto.Title, blogUpdateDto.ImageFile, ImageType.Blog);
                Image image = new(imageUpload.FullName, blogUpdateDto.ImageFile.ContentType, userEmail);
                await unitOfWork.GetRepository<Image>().AddAsync(image);
                blog.ImageId = image.Id;

            }

            mapper.Map(blogUpdateDto, blog);
            blog.ModifiedDate = DateTime.Now;
            blog.ModifiedBy = userEmail;

            await unitOfWork.GetRepository<Blog>().UpdateAsync(blog);
            await unitOfWork.SaveAsync();

            return blog.Title;

        }


        public async Task<string> DeleteBlogAsync(int blogId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var blog = await unitOfWork.GetRepository<Blog>().GetByIdAsync(blogId);
            blog.IsDeleted = true;
            blog.DeletedDate = DateTime.Now;
            blog.DeletedBy = userEmail;
            await unitOfWork.GetRepository<Blog>().UpdateAsync(blog);
            await unitOfWork.SaveAsync();
            return blog.Title;
        }

    }
}
