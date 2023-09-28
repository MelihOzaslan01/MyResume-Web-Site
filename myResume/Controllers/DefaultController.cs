using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace myResume.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}

		public PartialViewResult NavBarPartial()
		{
			return PartialView();
		}
		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult SendMessage(Message message)
		{
			MessageManager _messageManager = new MessageManager(new EfMessageDal());
			message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			message.Status = true;
			_messageManager.TAdd(message);
			return PartialView();
		}
	}
}
