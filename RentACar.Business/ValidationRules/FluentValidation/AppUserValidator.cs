using FluentValidation;
using RentACar.Core.Entities.Concrete;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class AppUserValidator : AbstractValidator<User>
    {
        public AppUserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.FirstName).MinimumLength(2);
            RuleFor(x => x.FirstName).MaximumLength(50);

            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.LastName).MinimumLength(2);
            RuleFor(x => x.LastName).MaximumLength(50);

            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).MaximumLength(50);
            RuleFor(x => x.Email).EmailAddress();

        }
    }
}
