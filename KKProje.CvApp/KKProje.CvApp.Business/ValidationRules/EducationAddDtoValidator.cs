using FluentValidation;
using KKProje.CvApp.DTO.DTOs.EducationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKProje.CvApp.Business.ValidationRules
{
    public class EducationAddDtoValidator : AbstractValidator<EducationAddDto>
    {
        public EducationAddDtoValidator()
        {
            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık Boş Bırakılamaz!");
            RuleFor(I => I.SubTitle).NotEmpty().WithMessage("Alt Başlık Boş Bırakılamaz!");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama Boş Bırakılamaz!");
            RuleFor(I => I.StartDate).NotEmpty().WithMessage("Başlangıç Tarihi Boş Bırakılamaz!");
        }
    }
}
