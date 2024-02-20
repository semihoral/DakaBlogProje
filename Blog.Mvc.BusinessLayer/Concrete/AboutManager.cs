using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.DataAccesLayer.Abstract;
using DakaBlog.Mvc.EntityLayer.Concrete;
using DataAccesLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public List<About> GetList()
		{
			return _aboutDal.GetListAll();
		}
	}
}
