using DataAccess.Entities;
using FluentValidation;

namespace Business.Validators
{
    public class AccountValidator : AbstractValidator<Account>
    {
        public AccountValidator()
        {
            RuleFor(x => x.FirstName).NotNull().Length(1, 30);
            RuleFor(x => x.LastName).NotNull().Length(1, 30);
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.Gsm).NotNull().MaximumLength(10);
        }
    }
}