using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {

        public WriterValidator()
        {
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("E-posta geçerli bir e-posta adresi değil.");
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adi Ve Soyadi Bos Gecilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Bos Gecilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre Bos Gecilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lutfen En Az 2 Karakter Girisi Yapin");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lutfen En Fazla 50 Karakterlik Veri Girisi Yapin");
            RuleFor(x => x.WriterPassword).Matches(@"(?=.*[a-z])(?=.*[A-Z])").WithMessage("En az 1 buyuk ve 1 kucuk karakter giriniz");


        }



    }
}
