using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Service.Helpers;
using Service.Services.Abstractions;
using Service.Services.Concrete;
using Service.FluentValidations;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IContactMessageService, ContactMessageService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IDashboardService, DashboardService>();

            // Claim principal için
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper(assembly);


            services.AddControllersWithViews()
                .AddFluentValidation(opt =>
                {
                    opt.RegisterValidatorsFromAssemblyContaining<BlogValidator>();
                    opt.DisableDataAnnotationsValidation = true;
                    opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
                });

            return services;
        }
    }
}
