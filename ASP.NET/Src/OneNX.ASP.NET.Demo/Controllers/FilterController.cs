using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneNX.ASP.NET.Demo.Controllers
{
	public class FilterController : Controller
	{
		#region Controller methods
		// GET: Filter
		public ActionResult Index()
		{
			return View();
		}

		// GET: Filter/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Filter/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Filter/Create
		[HttpPost]
		public ActionResult Create(FormCollection collection)
		{
			try
			{
				// TODO: Add insert logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Filter/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Filter/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Filter/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Filter/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
		#endregion

		#region Overrides
		protected override void OnAuthorization(AuthorizationContext filterContext)
		{
			//base.OnAuthorization(filterContext);
			var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.ToLower();
			var actionName = filterContext.ActionDescriptor.ActionName.ToLower();
			filterContext.HttpContext.Response.Write("身份验证过滤器OnAuthorization作用于" + controllerName + "控制器下的" + actionName + "方法</br>");
		}

		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			//base.OnActionExecuting(filterContext);
			var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.ToLower();
			var actionName = filterContext.ActionDescriptor.ActionName.ToLower();
			filterContext.HttpContext.Response.Write("行为过滤器作用于OnActionExecuting" + controllerName + "控制器下的" + actionName + "方法之前</br>");
		}
		protected override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			//base.OnActionExecuted(filterContext);
			var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.ToLower();
			var actionName = filterContext.ActionDescriptor.ActionName.ToLower();
			filterContext.HttpContext.Response.Write("行为过滤器作用于OnActionExecuted" + controllerName + "控制器下的" + actionName + "方法之后</br>");
		}

		protected override void OnResultExecuting(ResultExecutingContext filterContext)
		{
			//base.OnResultExecuting(filterContext);
			filterContext.HttpContext.Response.Write("结果过滤器OnResultExecuting作用于action运行之后，页面加载之前");
		}

		protected override void OnResultExecuted(ResultExecutedContext filterContext)
		{
			//base.OnResultExecuted(filterContext);
			
			filterContext.HttpContext.Response.Write("结果过滤器OnResultExecuted用于页面渲染之后");
		}

		protected override void OnException(ExceptionContext filterContext)
		{
			base.OnException(filterContext);
			var errMsg = filterContext.Exception;
			filterContext.Result = new RedirectResult("/error.html");
		}
		#endregion
	}
}
