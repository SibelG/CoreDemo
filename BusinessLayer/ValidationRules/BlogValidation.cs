using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidation : AbstractValidator<Blog>
    {
        public BlogValidation()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage(" Blog title cannot be left blank ");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog content cannot be left blank");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog image cannot be left blank");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog Title cannot be longer than 150 characters");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog Title cannot be longer than 150 characters");
        }
    }
}
