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
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(a => a.ProductName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(a => a.UnitPrice).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(a => a.BarkodNo).NotEmpty().WithMessage("Boş geçilemez");
        }
    }
}
