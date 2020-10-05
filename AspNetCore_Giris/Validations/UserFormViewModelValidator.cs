using AspNetCore_Giris.Models;
using FluentValidation;

namespace AspNetCore_Giris.Validations
{
    public class UserFormViewModelValidator : AbstractValidator<UserFormViewModel>
    {
        public UserFormViewModelValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Ad alanı kesinlikle boş geçilmemeli!")
                .MinimumLength(3)
                .MaximumLength(10);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Must(x => x?.ToLower() == "bozkuş").When(x => x.FirstName?.ToLower() == "sinan");
        }
    }
}
