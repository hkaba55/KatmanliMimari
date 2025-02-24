﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Concrete.Entity;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty();
            RuleFor(c => c.CategoryName).MinimumLength(2);

        }
    }
}
