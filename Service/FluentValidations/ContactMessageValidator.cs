using Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FluentValidations
{
    public class ContactMessageValidator : AbstractValidator<ContactMessage>
    {
        public ContactMessageValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Adı ve Soyadı");

            RuleFor(x => x.Email)
               .NotEmpty()
               .NotNull()
               .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");

            RuleFor(x => x.Message)
               .NotEmpty()
               .NotNull()
               .WithName("Mesaj");

            RuleFor(x => x.PhoneNumber)
               .NotEmpty()
               .NotNull()
               .WithName("Telefon");
            
               

        }
    }
}
