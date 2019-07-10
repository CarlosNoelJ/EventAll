using FluentValidation;

namespace EventAll.Models.FluentValidator
{
    public class EHostValidator : AbstractValidator<EHost>
    {
        public EHostValidator()
        {
            RuleFor(host => host.Id)
                .NotEmpty().WithMessage("Can't be empty");

            RuleFor(host => host.Name)
                .NotEmpty().WithMessage("Can't be empty")
                .Length(3, 50).WithMessage("Please Complete with more than 3 characters and 50 maximun.");

            RuleFor(host => host.UserName)
                .NotEmpty().WithMessage("Can't be empty")
                .Length(3, 50).WithMessage("Please Complete with more than 3 characters and 50 maximun.");

            RuleFor(host => host.LastName)
                .NotEmpty()
                .Length(3, 50).WithMessage("Please Complete with more than 3 characters and 50 maximun.");

            RuleFor(host => host.Password)
                .NotEmpty().WithMessage("Can't be empty")
                .Length(3, 50).WithMessage("Please Complete with more than 3 characters and 50 maximun.");

            RuleFor(host => host.Dni)
                .NotEmpty().WithMessage("Can't be empty")
                .ExclusiveBetween(6,9).WithMessage("Must be between 6 and 9 numbers");
        }
    }
}
