using DakaBlog.Mvc.BusinessLayer.Abstract;
using DakaBlog.Mvc.DataAccesLayer.Abstract;
using DakaBlog.Mvc.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentdal;

		public CommentManager(ICommentDal commentdal)
		{
			_commentdal = commentdal;
		}

		public void CommentAdd(Comment comment)
		{
			_commentdal.Add(comment);
		}

		public List<Comment> GetList(int id)
		{
			return _commentdal.GetListAll(x => x.BlogId == id);
		}
	}
}
