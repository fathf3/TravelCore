using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator() { 
        
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş olamaz");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Boş olamaz"); 
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Boş olamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Boş olamaz");
            
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Sifreler uyusmuyor.");
        }
    }
}
