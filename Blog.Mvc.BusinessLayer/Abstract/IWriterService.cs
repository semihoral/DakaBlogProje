﻿using DakaBlog.Mvc.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.BusinessLayer.Abstract
{
	public interface IwriterService
	{
		void WriterAdd(Writer writer);
	}
}
