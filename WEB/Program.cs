using Service.Extensions;
using Data.Extensions;
using Microsoft.AspNetCore.Identity;
using NToastNotify;
using Data.Context;
using Entity.Entities;
using Service.Describers;
using WEB.Filters.BlogVisitors;

var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
builder.Services.AddSession();



// Add services to the container.
builder.Services.AddControllersWithViews(opt =>
{
    opt.Filters.Add<BlogVisitorFilter>();
})
    .AddNToastNotifyToastr(new ToastrOptions()
    {
        PositionClass = ToastPositions.BottomRight,
        TimeOut = 3000
    })
    .AddRazorRuntimeCompilation();

// Identity 
builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false; // Şifrenin özel karakter içermesine gerek bulunmuyor
    opt.Password.RequireLowercase = false; // Şifrede büyük harf olmasına gerek bulunmuyor
    opt.Password.RequireUppercase = false; // Şifrede küçük harf olmasına gerek bulunmuyor
})
    .AddRoleManager<RoleManager<AppRole>>() 
    .AddErrorDescriber<CustomIdentityErrorDescriber>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();


// Cookie konfigürasyonu
builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = new PathString("/Admin/Auth/Login"); 
    config.LogoutPath = new PathString("/Admin/Auth/Logout");
    config.Cookie = new CookieBuilder
    {
        Name = "Blog",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest //Always SSL Sertifikalar sayfalar güvenli oluyor, canlıya çıkarken tekrar kontrol ederim
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(7);
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); // Yetkini yoksa işlemi gerçekleştiremezsiniz uyarısı için.
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseNToastNotify();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapDefaultControllerRoute();
});

app.Run();
