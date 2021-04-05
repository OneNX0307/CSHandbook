using OneNX.ASP.NET.Demo.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneNX.ASP.NET.Demo.Controllers
{
	[MyAuthorization]
	[MyAction]
	[MyException]
	public class FIlterAttributeController : Controller
	{
		[MyResult]
		public ActionResult Index()
		{
			return View();
		}

		[MyResult]
		public void Create()
		{

		}

		[MyActionPure]
		public void Delete()
		{

		}
	}
}