using CoreCV_Project.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("En az 5 karakter kullanılmalıdır");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("En fazla 100 karakter kullanılmalıdır.");
        }
    }
}
