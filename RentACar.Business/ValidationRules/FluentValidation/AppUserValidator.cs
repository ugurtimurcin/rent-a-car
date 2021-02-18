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
    public class AppUserValidator : AbstractValidator<AppUser>
    {
        public AppUserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.FirstName).MinimumLength(2);
            RuleFor(x => x.FirstName).MaximumLength(20);

            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.LastName).MinimumLength(2);
            RuleFor(x => x.LastName).MaximumLength(25);

            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).MaximumLength(30);
            RuleFor(x => x.Email).EmailAddress();

            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(6);
            RuleFor(x => x.Password).MaximumLength(20);

            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.UserName).MinimumLength(2);
            RuleFor(x => x.UserName).MaximumLength(20);

        }
    }
}
