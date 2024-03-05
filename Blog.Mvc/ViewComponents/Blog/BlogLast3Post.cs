using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.ViewComponents.Blog
{
	public class BlogLast3Post : ViewComponent
	{
		//BlogManager bm = new BlogManager(new EfBlogRepository());
		private readonly IBlogService blogService;
        public BlogLast3Post(IBlogService blogService)
        {
            this.blogService = blogService;
        }
        public IViewComponentResult Invoke()
		{
			var values = blogService.GetLast3Blog();
			return View(values);
		}

	}
}
