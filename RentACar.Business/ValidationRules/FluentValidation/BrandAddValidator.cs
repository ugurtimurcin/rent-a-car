using FluentValidation;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class BrandAddValidator : AbstractValidator<BrandAddDto>
    {
        public BrandAddValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Brand name cannot be empty").MinimumLength(2).WithMessage("Brand name must be at least 2 characters").MaximumLength(30).WithMessage("Brand name must be shorter than 30 characters");
        }
    }
}
