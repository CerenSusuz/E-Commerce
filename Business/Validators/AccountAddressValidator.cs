using DataAccess.Entities;
using FluentValidation;

namespace Business.Validators
{
    public class AccountAddressValidator : AbstractValidator<AccountAddress>
    {
        public AccountAddressValidator()
        {
            
        }
    }
}