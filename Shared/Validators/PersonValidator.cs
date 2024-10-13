using FluentValidation;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Validators
{
    internal class PersonValidator : AbstractValidator<PersonDto>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName).NotNull().Length(3, 30);
            RuleFor(p => p.LastName).NotNull().Length(5, 50);
            RuleFor(p => p.Email).NotNull().EmailAddress();
            RuleFor(p => p.Phone).NotNull();
            RuleFor(p => p.NationalCode).NotNull().Matches("^[0-9]{10}$").WithMessage("National Code must be 10 charecters");
            RuleFor(p => p.ProfileId).NotNull();
        }
    }
}
