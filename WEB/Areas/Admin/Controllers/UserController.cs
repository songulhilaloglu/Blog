using AutoMapper;
using Entity.DTOs.Users;
using Entity.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Service.Extensions;
using Service.Services.Abstractions;
using WEB.Consts;
using WEB.ResultMessages;

namespace WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IMapper mapper;
        private readonly IValidator<AppUser> validator;
        private readonly IToastNotification toast;

        public UserController(IUserService userService, RoleManager<AppRole> roleManager, IMapper mapper, IValidator<AppUser> validator, IToastNotification toast)
        {
            this.userService = userService;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }


        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Index()
        {
            var users = await userService.GetAllUsersWithRoleAsync();
            return View(users);
        }


        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add()
        {
            var roles = await userService.GetAllRolesAsync();
            return View(new UserAddDto { Roles = roles });
        }


        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            
            var validation = await validator.ValidateAsync(map);
            var roles = await userService.GetAllRolesAsync();
            if (ModelState.IsValid)
            {
                var result = await userService.CreateUserAsync(userAddDto);
                if (result.Succeeded)
                {
                    toast.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email), new ToastrOptions { Title = "İşlem Başarılı" });
                    return RedirectToAction("Index", "User", new { Area = "Admin" });
                }
                else
                {
                    result.AddToIdentityModelState(this.ModelState);
                    validation.AddToModelState(this.ModelState);
                    return View(new UserAddDto { Roles = roles });

                }
            }
            return View(new UserAddDto { Roles = roles });
        }
    }
}
