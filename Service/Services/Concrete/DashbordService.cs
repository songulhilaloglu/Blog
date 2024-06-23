using Data.UnitOfWorks;
using Entity.Entities;
using Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Concrete
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork unitOfWork;

        public DashboardService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<(int, int, int, int)> GetDashboardCounts()
        {
            // Toplam makale sayısı
            var totalBlogCount = await unitOfWork.GetRepository<Blog>().CountAsync(x => !x.IsDeleted);

            // Toplam kategori sayısı
            var totalCategoryCount = await unitOfWork.GetRepository<Category>().CountAsync();

            // Toplam bize ulaşın mesaj sayısı
            var totalContactMessageCount = await unitOfWork.GetRepository<ContactMessage>().CountAsync();

            // Toplam kullanıcı sayısı
            var totalUserCount = await unitOfWork.GetRepository<AppUser>().CountAsync();

            return (totalBlogCount, totalCategoryCount, totalContactMessageCount, totalUserCount);
        }

    }
}
