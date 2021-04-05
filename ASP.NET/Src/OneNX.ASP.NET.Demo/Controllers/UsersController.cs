using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneNX.ASP.NET.Demo.Controllers
{
	public class UsersController : Controller
	{
		// GET: Users
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public JsonResult Login()
		{

			return new JsonResult();
		}
	}
}