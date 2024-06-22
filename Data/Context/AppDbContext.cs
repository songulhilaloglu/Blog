using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Entity.Entities.Image> Images { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<About> Abouts { get; set; }

        //Assembly: Katmanın adıdır.
        //ApplyConfigurationsFromAssembly sayesinde IEntityTypeConfiguration dan katılım alan tüm classlarda mapping yapacaktır. Tek tek yapmak yerine tek seferde tüm classlarda geçerli olur.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
