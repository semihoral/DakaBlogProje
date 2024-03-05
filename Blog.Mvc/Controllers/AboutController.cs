using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.Controllers
{
	public class AboutController : Controller
	{
		private readonly IAboutService aboutService;

        public AboutController(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }

        //AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
		{
			var values = aboutService.GetList();
			return View(values);
		}
		public PartialViewResult SocialMediaAbout()
		{
			
			return PartialView();
		}
	}
}
