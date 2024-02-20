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
	public class WriterManager : IwriterService
	{
		IWriterDal _writerdal;

        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public void WriterAdd(Writer writer)
        {
           _writerdal.Add(writer);
        }
    }
}
