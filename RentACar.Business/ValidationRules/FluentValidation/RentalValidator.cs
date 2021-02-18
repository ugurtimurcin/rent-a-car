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
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(x => x.RentDate).NotEmpty();
            RuleFor(x => x.ReturnDate).NotEmpty();
            RuleFor(x => x.CarId).NotEmpty().WithMessage("Chose a car").InclusiveBetween(0, int.MaxValue);
        }
    }
}
