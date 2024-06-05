using FluentValidation;
using KKProje.CvApp.DTO.DTOs.SocialMediaIconDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Business.ValidationRules
{
    public class SocialMediaIconUpdateDtoValidator : AbstractValidator<SocialMediaIconUpdateDto>
    {
        public SocialMediaIconUpdateDtoValidator()
        {
            RuleFor(I => I.AppUserId).InclusiveBetween(1, int.MaxValue).WithMessage("AppUserId Boş Geçilemez!");
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş Geçilemez!");
        }
    }
}
