using FluentValidation;
using KKProje.CvApp.DTO.DTOs.SocialMediaIconDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Business.ValidationRules
{
    public class SocialMediaIconAddDtoValidator : AbstractValidator<SocialMediaIconAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
            RuleFor(I => I.AppUserID).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş Geçilemez!");
            RuleFor(I => I.Icon).NotEmpty().WithMessage("Icon Boş Geçilemez!");
            RuleFor(I => I.Link).NotEmpty().WithMessage("Link Boş Geçilemez!");
        }
    }
}
