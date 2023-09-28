using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace myResume.ViewComponents.Contact
{
	public class SendMessage : ViewComponent
	{
		[HttpGet]
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
