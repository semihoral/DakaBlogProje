using DakaBlog.Mvc.DataAccesLayer.Repositories;
using DakaBlog.Mvc.EntityLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.DataAccesLayer.EntityFramework
{
	public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
	{
	}
}
