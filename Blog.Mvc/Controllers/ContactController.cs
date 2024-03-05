using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using DakaBlog.Mvc.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.Controllers
{
	public class ContactController : Controller
	{
		//ContactManager cm = new ContactManager(new EfContactRepository());
		private readonly IContactService contactService;
        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact p)
		{
			p.ContactDate=	DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ContactStatus = true;
            contactService.ContactAdd(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
