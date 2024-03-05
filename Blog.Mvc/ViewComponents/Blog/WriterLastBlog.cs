using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
        //BlogManager bm = new BlogManager(new EfBlogRepository());
        private readonly IBlogService blogService;
        public WriterLastBlog(IBlogService blogService)
        {
            this.blogService = blogService;
        }
        public IViewComponentResult Invoke()
		{
			var values = blogService.GetBlogByWriter(1);
			return View(values);
		}
	}
}
