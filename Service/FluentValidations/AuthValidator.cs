using Entity.DTOs.Users;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FluentValidations
{
    public class AuthValidator : AbstractValidator<UserLoginDto>
    {
        public AuthValidator()
        {
            RuleFor(x => x.Email)
             .NotEmpty()
             .WithName("Email");

            RuleFor(x => x.Password)
            .NotEmpty()
            .WithName("Şifre");
        }
    }
}
