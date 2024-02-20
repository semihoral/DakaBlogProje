using DakaBlog.Mvc.DataAccesLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.Repositories;
using DakaBlog.Mvc.EntityLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.DataAccesLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
	{
		public List<Blog> GetListWithCategory()
		{
			using (var c = new Context())
			{
				return c.Blogs.Include(x => x.Category).ToList();
			}
		}
	}
}
