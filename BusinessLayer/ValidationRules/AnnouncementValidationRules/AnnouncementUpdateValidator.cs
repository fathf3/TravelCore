using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;


namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Baslık boş olamaz");
            RuleFor(x => x.Content).NotEmpty().WithMessage(";İçerik boş olamaz");


        }

    }
}
