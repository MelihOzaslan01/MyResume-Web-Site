using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace myResume.ViewComponents.Service
{

	public class ServiceList : ViewComponent
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		
		public IViewComponentResult Invoke()
		{
			var values = serviceManager.TGetList();
			return View(values);
		}

	}
}
