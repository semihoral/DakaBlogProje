﻿using DakaBlog.Mvc.EntityLayer.Concrete;
using DakaBlog.Mvc.DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace DakaBlog.Mvc.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public async  Task<IActionResult> Index(Writer p)
		{
			Context c = new Context();
			var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
			if (datavalue != null)
			{
				//HttpContext.Session.SetString("username", p.WriterMail);
				var claims  = new List<Claim>
				{
					new Claim(ClaimTypes.Name , p.WriterMail)
				};
				var useridentity = new ClaimsIdentity(claims,"a");
				ClaimsPrincipal principal= new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Writer");

			}
			else
			{
				return View();			}
		}
	}
}
