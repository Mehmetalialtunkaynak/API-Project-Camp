﻿using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {


            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin!");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter veri girişi yapın!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter veri girişi yapın!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez").GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz").LessThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz, girdiğiniz xdeğeri kontrol edin!");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez!");



            //RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            //RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır");
            //RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Ürün adı en fazla 50 karakter olmalıdır");

            //RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün Fiyatı bilgisi boş geçilemez").GreaterThan(0).WithMessage("Ürün Fiyatı Negatif Olamaz").LessThan(1000).WithMessage("Ürün Fiyatı bu kadar Yüksek olamaz , Girdiğiniz değeri kontrol ediniz");


            //RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez !");

            //RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Ürün resmi boş geçilemez !").Must(x => x.EndsWith(".jpg") || x.EndsWith(".png")).WithMessage("Resim uzantısı jpg veya png olmalıdır");




        }
    }
}
