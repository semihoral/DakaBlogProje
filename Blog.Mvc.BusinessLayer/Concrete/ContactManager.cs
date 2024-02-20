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
	public class ContactManager : IContactService
	{
		IContactDal contactDal;

		public ContactManager(IContactDal contactDal)
		{
			this.contactDal = contactDal;
		}

		public void ContactAdd(Contact contact)
		{
			contactDal.Add(contact);
		}
	}
}
