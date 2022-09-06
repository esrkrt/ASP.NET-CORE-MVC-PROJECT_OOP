using EntityLayer.Cocrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FulentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsizniz...");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı en az 3 karatkter olmalıdır...");
        }
    }
}
