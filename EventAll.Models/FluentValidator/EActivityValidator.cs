using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventAll.Models.FluentValidator
{
    public class EActivityValidator : AbstractValidator<EActivity>
    {
        public EActivityValidator()
        {
            RuleFor(act => act.Id).NotEmpty();

            RuleFor(act => act.DishName)
                .Length(3,50)
                .NotEmpty();

            RuleFor(act => act.Price)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(act => act.QuantityOfDishes)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(act => act.DateOfActivity)
                .NotEmpty();

            RuleFor(act => act.EPay)
                .NotEmpty()
                .NotNull();

            RuleFor(act => act.EPay)
                .NotEmpty()
                .NotNull();

            RuleFor(act => act.EType)
                .NotEmpty()
                .NotNull();

            RuleFor(act => act.Ehost)
                .NotEmpty()
                .NotNull();

        }
    }
}
