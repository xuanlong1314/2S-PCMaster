﻿using Microsoft.AspNetCore.Mvc;

namespace PCMaster.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
