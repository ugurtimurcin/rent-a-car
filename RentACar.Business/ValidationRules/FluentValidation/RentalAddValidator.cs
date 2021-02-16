using FluentValidation;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class RentalAddValidator : AbstractValidator<RentalAddDto>
    {
        public RentalAddValidator()
        {
            RuleFor(x => x.RentDate).NotEmpty().WithMessage("Chose rent date");
            RuleFor(x => x.ReturnDate).NotEmpty().WithMessage("Chose return date");
            RuleFor(x => x.CarId).NotEmpty().WithMessage("Chose a car").InclusiveBetween(0, int.MaxValue);
        }
    }
}
