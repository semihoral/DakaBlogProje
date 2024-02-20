﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakaBlog.Mvc.EntityLayer.Concrete
{
	public class Writer
	{
		[Key]
		public int WriterId { get; set; }
		public string? Writername { get; set; }
		public string? WriterAbout { get; set; }
		public string? WriterImage { get; set; }
		public string? WriterMail { get; set; }
		public string? WriterPassword { get; set; }
		public bool WriterStatus { get; set; }
		public List<Blog> Blogs { get; set; }
	}
}
