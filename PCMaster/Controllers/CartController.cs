using Microsoft.AspNetCore.Mvc;

namespace PCMaster.Controllers
{
	public class CartController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
