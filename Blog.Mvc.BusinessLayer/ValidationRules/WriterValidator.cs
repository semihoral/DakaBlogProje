﻿using DakaBlog.Mvc.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.Writername).NotEmpty().WithMessage("Yazar Adı Soyadı Boş Geçilemez!");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Kısmı Boş Geçilemez!");
			RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Görsel Yolu Boş Geçilemez!");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez")
				.MinimumLength(8).WithMessage("Şifre 8 karakterden küçük olamaz.")
				.MaximumLength(16).WithMessage("Şifre 16 karakterden büyük olamaz.")
				.Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.")
				.Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
				.Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır");
			RuleFor(x => x.Writername).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
			RuleFor(x => x.Writername).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın");

		}
	}
}
