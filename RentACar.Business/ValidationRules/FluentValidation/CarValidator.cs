using FluentValidation;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.ModelYear).NotEmpty();

            RuleFor(x => x.DailyPrice).NotEmpty();
            
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Description).MinimumLength(10);
            
            RuleFor(x => x.BrandId).NotEmpty().WithMessage("Chose a brand").InclusiveBetween(0, int.MaxValue);
            RuleFor(x => x.ColorId).NotEmpty().WithMessage("Chose a color").InclusiveBetween(0, int.MaxValue);
        }
    }
}
