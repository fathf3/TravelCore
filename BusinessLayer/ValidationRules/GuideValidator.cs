using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator :AbstractValidator<Guide>
    {
        public GuideValidator() {


            RuleFor(x => x.Name).NotEmpty().WithMessage("Lutfen isim giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lutfen açıklama giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lutfen resim giriniz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lutfen 2 karakterden fazla isim giriniz");
    
        }
    }
}
