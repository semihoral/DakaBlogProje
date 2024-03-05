using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.EntityLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			_blogDal.Add(blog);
		}

		public void BlogDelete(Blog blog)
		{
			_blogDal.Delete(blog);
		}

		public void BlogUpdate(Blog blog)
		{
			_blogDal.Update(blog);
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public Blog GetById(int id)
		{
			return _blogDal.GetById(id);
		}
		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x => x.BlogId == id);
		}

		public List<Blog> GetList()
		{
			return _blogDal.GetListAll();
		}
		public List<Blog> GetLast3Blog()
		{
			return _blogDal.GetListAll().Take(3).ToList();
		}

		public List<Blog> GetBlogByWriter(int id)
		{
			return _blogDal.GetListAll(x => x.WriterId == id);
		}
	}
}
