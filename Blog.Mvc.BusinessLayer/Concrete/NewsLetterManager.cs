using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.DataAccesLayer.Abstract;
using DakaBlog.Mvc.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.BusinessLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsLetterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal)
		{
			_newsLetterDal = newsLetterDal;
		}

		public void AddNewsLetter(NewsLetter newsLetter)
		{
			_newsLetterDal.Add(newsLetter);
		}
	}
}
