using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace myResume.Controllers
{
	public class SendMessageController : Controller
	{
		MessageManager _messageManager = new MessageManager(new EfMessageDal());
		[HttpPost]

		public IActionResult Index(Message message)
		{
			message.Date = DateTime.Now.ToLocalTime();
			message.Status = true;
			_messageManager.TAdd(message);
			return Redirect("/Default/Index#contact");

		}
	}
}
