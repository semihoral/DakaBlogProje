﻿using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using DakaBlog.Mvc.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.Controllers
{
	public class NewsLetterController : Controller
	{
		//NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
		private readonly INewsLetterService newsLetterService;
        public NewsLetterController(INewsLetterService newsLetterService)
        {
            this.newsLetterService = newsLetterService;
        }

        [HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter p)
		{
			p.MailStatus = true;
            newsLetterService.AddNewsLetter(p);
			return PartialView();
		}
	}
}
