using Business.Models;
using Business.Models.BaseDto;
using FluentValidation;

namespace Business.Validators
{
    public class UserGroupValidator: AbstractValidator<UserGroupDto>
    {
        public UserGroupValidator()
        {
            RuleFor(x => x.Description).NotNull().Length(1, 30);
        }
    }
}