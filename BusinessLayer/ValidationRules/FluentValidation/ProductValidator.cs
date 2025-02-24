using Domain.Concrete.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MaximumLength(2);
            RuleFor(p => p.UnitPrice).GreaterThan(0);
        }

    }
}
