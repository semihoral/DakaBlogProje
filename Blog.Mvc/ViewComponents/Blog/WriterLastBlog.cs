using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogByWriter(1);
			return View(values);
		}
	}
}
