using DakaBlog.Mvc.DataAccesLayer.Abstract;
using DakaBlog.Mvc.DataAccesLayer.Repositories;
using DakaBlog.Mvc.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.DataAccesLayer.EntityFramework
{
	public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
	{

	}
}
