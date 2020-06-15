using EsenAppFramework.BarkodApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.UI.FluentValidation
{
    public class ManagerValidator : AbstractValidator<Manager>
    {
        public ManagerValidator()
        {

            RuleFor(a => a.UserName).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(a => a.Password).NotEmpty().WithMessage("Boş geçilemez");
        }
    }
}
