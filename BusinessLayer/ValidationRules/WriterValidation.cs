using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidation : AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer name and surname cannot be left blank ");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("e-Mail cannot be left blank..");
            RuleFor(x=>x.WriterPass).NotEmpty().WithMessage("Password cannot be left blank..");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Please enter the least two characters..");
            RuleFor(x => x.WriterName).MaximumLength(2).WithMessage("Please enter the most two characters..");
        }
    }
}
