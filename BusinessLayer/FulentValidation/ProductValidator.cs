using EntityLayer.Cocrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FulentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adını Boş Geçemezsizniz...");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün Adın en az 3 karatkter olmalıdır...");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısını Boş Geçemezsizniz...");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Boş Geçilemez...");
        }
    }
}
