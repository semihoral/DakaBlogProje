using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.BusinessLayer.ValidationRules;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using DakaBlog.Mvc.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(p);
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "DakaProje Test";
				wm.WriterAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else 
			{
				foreach (var item in results.Errors)
				{ 
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}
			}
			return View();
        }
    }
}
