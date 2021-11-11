using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {

        public BlogValidator()
        {

            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog Basligini Bos Gecemezsiniz");
            RuleFor(x=>x.BlogContent).NotEmpty().WithMessage("Blog Icerigini Bos Gecemezsiniz");
            RuleFor(x=>x.BlogImage).NotEmpty().WithMessage("Blog Gorselini Bos Gecemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("150 Karakterden Daha Az Veri  Girisi Yapin");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("5 Karakterden Daha Az Veri  Girisi Yapin");


        }

    }
}
