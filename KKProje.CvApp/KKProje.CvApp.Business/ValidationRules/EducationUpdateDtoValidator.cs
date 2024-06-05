using FluentValidation;
using KKProje.CvApp.DTO.DTOs.EducationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Business.ValidationRules
{
    public class EducationUpdateDtoValidator : AbstractValidator<EducationUpdateDto>
    {
        public EducationUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş Geçilemez!");
            //RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez!");
        }
    }
}
