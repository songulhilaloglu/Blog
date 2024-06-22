using Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FluentValidations
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık zorunludur")
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Başlık");

            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("İçerik zorunludur")
                .NotNull()
                .MinimumLength(3)
                .WithName("İçerik");

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("Kategori zorunludur")
                .NotNull()
                .WithName("Kategori");
         
        }
    }
}
