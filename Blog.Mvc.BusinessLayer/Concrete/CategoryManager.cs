using DakaBlog.Mvc.EntityLayer.Concrete;
using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.DataAccesLayer.Abstract;
using DakaBlog.Mvc.DataAccesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}
		public void CategoryAdd(Category category)
		{
			_categoryDal.Add(category);
		}

		public void CategoryDelete(Category category)
		{
			_categoryDal.Delete(category);
		}

		public void CategoryUpdate(Category category)
		{
			_categoryDal.Update(category);
		}

		public Category GetById(int id)
		{
			return _categoryDal.GetById(id);
		}

		public List<Category> GetList()
		{
			return _categoryDal.GetListAll();
		}
	}
}
