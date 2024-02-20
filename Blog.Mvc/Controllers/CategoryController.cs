using DakaBlog.Mvc.BusinessLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.Controllers
{
	public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
