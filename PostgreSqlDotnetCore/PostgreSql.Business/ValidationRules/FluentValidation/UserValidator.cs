using FluentValidation;
using PostgreSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email adress is required").EmailAddress().WithMessage("A valid email is required");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("Phone number is required");
        }
    }
}
