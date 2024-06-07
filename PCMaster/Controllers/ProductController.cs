using Microsoft.AspNetCore.Mvc;
namespace PCMaster.Controllers
{
	public class ProductController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Details()
		{
			return View();
		}
	}
}
