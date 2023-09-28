using Microsoft.AspNetCore.Mvc;

namespace myResume.Controllers
{
	public class FeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
