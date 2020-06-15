using EsenAppFramework.BarkodApp.Entities.Concrete;
using EsenAppFramework.BarkodApp.UI.Helper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.UI.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Categories>
    {
        public CategoryValidator()
        {

            RuleFor(a => a.CategoryName).NotEmpty().WithMessage("Boş geçilemez");
        }
    }
}
