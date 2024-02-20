using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());

		public IViewComponentResult Invoke()
		{
			var values = cm.GetList();
			return View(values);
		}
	}
}
