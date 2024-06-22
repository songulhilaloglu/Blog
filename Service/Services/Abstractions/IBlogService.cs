﻿using Entity.DTOs.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Abstractions
{
    public interface IBlogService
    {
        Task<BlogListDto> GetAllByPagingAsync(int? categoryId, int currentPage = 1, int pageSize = 3,
          bool isAscending = false);
        Task<List<BlogDto>> GetAllBlogsAsync();
        Task<List<BlogDto>> GetAllBlogsDeletedAsync();
        Task<BlogDto> GetBlogAsync(int blogId);
        Task CreateBlogAsync(BlogAddDto blogAddDto);
        Task<string> UpdateBlogAsync(BlogUpdateDto blogUpdateDto);
        Task<string> SafeDeleteBlogAsync(int blogId);
        Task<string> UndoDeleteBlogAsync(int blogId);
        Task<BlogListDto> SearchAsync(string keyword, int currentPage = 1, int pageSize = 3,
         bool isAscending = false);

    }
}