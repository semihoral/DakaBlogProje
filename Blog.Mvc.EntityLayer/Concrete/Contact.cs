using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.EntityLayer.Concrete
{
	public class Contact
	{
		[Key]
		public bool ContactId { get; set; }
		public string ContactUserName { get; set; }
		public string ContactMail { get; set; }
		public string ContactSubject { get; set; }
		public string ContactMessage { get; set; }
		public DateTime ContactDate { get; set; }
		public bool ContactStatus { get; set; }
	}
}
