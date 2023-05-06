using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Aciklama kismi bos gecilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim kismi bos gecilemez");
        }


    }
}
