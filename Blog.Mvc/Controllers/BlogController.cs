using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		private readonly IBlogService blogService;

		public BlogController(IBlogService blogService)
		{
			this.blogService = blogService;
		}
		public IActionResult Index()
		{
			var values = blogService.GetBlogListWithCategory();
			return View(values);
		}
		public IActionResult BlogReadAll(int id)
		{
			ViewBag.i = id;
			var values = blogService.GetBlogByID(id);
			return View(values);
		}
	}
}
