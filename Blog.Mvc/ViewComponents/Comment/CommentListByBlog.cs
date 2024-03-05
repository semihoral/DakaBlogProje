using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
        //CommentManager cm = new CommentManager(new EfCommentRepository());
        private readonly ICommentService commentService;
        public CommentListByBlog(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        public IViewComponentResult Invoke(int id)
		{
			var values = commentService.GetList(id);
			return View(values);
		}
	}
}