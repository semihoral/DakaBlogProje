using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
        //CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private readonly ICategoryService categoryService;
        public CategoryList(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
		{
			var values = categoryService.GetList();
			return View(values);
		}
	}
}
