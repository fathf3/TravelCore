using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class ContactUsValidator : AbstractValidator<SendMessageDTO>
    {
        public ContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Bos gecilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Bos gecilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj Bos gecilemez");
           

        }
    }
}
