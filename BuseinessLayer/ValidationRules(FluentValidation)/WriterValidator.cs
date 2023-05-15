using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuseinessLayer.ValidationRules_FluentValidation_
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş bırakılamaz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş bırakılamaz.");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Yazar adı 3 karakterden uzun olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı adı 20 karakterden kısa olmalıdır.");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Yazar soyadı adı 3 karakterden uzun olmalıdır.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar soyadı 20 karakterden kısa olmalıdır.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında kısmı boş bırakılamaz.");
        }
    }
}
