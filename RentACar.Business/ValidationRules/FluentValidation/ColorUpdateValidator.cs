using FluentValidation;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class ColorUpdateValidator : AbstractValidator<ColorUpdateDto>
    {
        public ColorUpdateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Color name cannot be empty").MinimumLength(2).WithMessage("Color name must be at least 2 characters").MaximumLength(20).WithMessage("Color name must be shorter than 20 characters");
        }
    }
}
