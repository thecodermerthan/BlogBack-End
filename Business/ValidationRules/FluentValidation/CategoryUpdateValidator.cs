﻿using DTO.DTOs.CategoryDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryUpdateValidator : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(0, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");

        }
    }
}
