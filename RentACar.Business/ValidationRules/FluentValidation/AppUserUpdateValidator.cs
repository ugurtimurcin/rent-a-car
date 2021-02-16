using FluentValidation;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class AppUserUpdateValidator : AbstractValidator<AppUserUpdateDto>
    {
        public AppUserUpdateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name cannot be empty").MinimumLength(2).WithMessage("First namemust be at least 2 characters").MaximumLength(20).WithMessage("First name must be shorter than 20 characters");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name cannot be empty").MinimumLength(2).WithMessage("Last name must be at least 2 characters").MaximumLength(25).WithMessage("Last name must be shorter than 25 characters");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be empty").MaximumLength(30).WithMessage("Email must be shorter than 30 characters").EmailAddress().WithMessage("Check your emailaddress");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty").MinimumLength(6).WithMessage("Password must be at least 6 characters").MaximumLength(20).WithMessage("First name must be shorter than 20 characters");
        }
    }
}
