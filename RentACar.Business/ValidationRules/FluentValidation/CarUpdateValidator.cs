using FluentValidation;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class CarUpdateValidator : AbstractValidator<CarUpdateDto>
    {
        public CarUpdateValidator()
        {
            RuleFor(x => x.ModelYear).NotEmpty().WithMessage("Model year cannot be empty");
            RuleFor(x => x.DailyPrice).NotEmpty().WithMessage("Daily price cannot be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be empty").MinimumLength(10).WithMessage("Description must be at least 10 characters");
            RuleFor(x => x.BrandId).NotEmpty().WithMessage("Chose a brand").InclusiveBetween(0, int.MaxValue);
            RuleFor(x => x.ColorId).NotEmpty().WithMessage("Chose a color").InclusiveBetween(0, int.MaxValue);
        }
    }
}
