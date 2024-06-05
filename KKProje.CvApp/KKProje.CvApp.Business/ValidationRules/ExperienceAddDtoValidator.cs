using FluentValidation;
using KKProje.CvApp.DTO.DTOs.ExperienceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Business.ValidationRules
{
    public class ExperienceAddDtoValidator : AbstractValidator<ExperienceAddDto>
    {
        public ExperienceAddDtoValidator()
        {
            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez!");
            RuleFor(I => I.SubTitle).NotEmpty().WithMessage("Alt Başlık Boş Geçilemez!");
            RuleFor(I => I.StartDate).NotEmpty().WithMessage("Başlangıç Tarihi Boş Geçilemez!");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez!");
        }
    }
}
