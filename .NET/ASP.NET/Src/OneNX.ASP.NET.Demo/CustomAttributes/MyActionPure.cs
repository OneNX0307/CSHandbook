using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneNX.ASP.NET.Demo.CustomAttributes
{
	public class MyActionPure : FilterAttribute, IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			throw new NotImplementedException();
		}

		public void OnActionExecuting(ActionExecutingContext filterContext)
		{
			throw new NotImplementedException();
		}
	}
}