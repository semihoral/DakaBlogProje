using DakaBlog.Mvc.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);
		void BlogDelete(Blog blog);
		void BlogUpdate(Blog blog);
		List<Blog> GetList();
		Blog GetById(int id);
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogByWriter(int id);
		List<Blog> GetBlogByID(int id);
		List<Blog> GetLast3Blog();
	}
}
