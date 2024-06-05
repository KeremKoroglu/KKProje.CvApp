using FluentValidation;
using KKProje.CvApp.DTO.DTOs.CertificationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Business.ValidationRules
{
    public class CertificationUpdateDtoValidator : AbstractValidator<CertificationUpdateDto>
    {
        public CertificationUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Alanı Boş Geçilemez!");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Sertifika Boş Geçilemez!");
        }
    }
}
