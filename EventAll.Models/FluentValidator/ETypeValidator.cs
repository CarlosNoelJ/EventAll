using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventAll.Models.FluentValidator
{
    public class ETypeValidator : AbstractValidator<EType>
    {
        public ETypeValidator()
        {
            RuleFor(Type => Type.Id)
                .NotEmpty().WithMessage("Must have a Event Type that exists.");

            RuleFor(eventType => eventType.NameType)
                .NotEmpty().WithMessage("Title of the Type Event must be completed")
                .Length(3, 50).WithMessage("Please Complete with more than 3 characters and 50 maximun.");
        }
    }
}
