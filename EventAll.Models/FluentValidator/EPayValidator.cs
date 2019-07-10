using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventAll.Models.FluentValidator
{
    public class EPayValidator : AbstractValidator<EPay>
    {
        public EPayValidator()
        {
            RuleFor(pay => pay.TypeOfPay)
                .NotEmpty()
                .Length(2,50);
        }
    }
}
