using OneNX.ASP.NET.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneNX.ASP.NET.Demo.Controllers
{
	public class HomeController : Controller
	{
		List<Employee> employees = new List<Employee>()
		{
			new Employee(){ Age =1, Country = "a", EmployeeID = 11, Name = "Alfred", State = "B"},
			new Employee(){ Age =1, Country = "a", EmployeeID = 11, Name = "Alfred", State = "B"},
			new Employee(){ Age =1, Country = "a", EmployeeID = 11, Name = "Alfred", State = "B"},
		};

		public ActionResult Index()
		{
			return View();
		}
		public ActionResult About()
		{
			return View();
		}
		public JsonResult List()
		{
			return Json(employees);
		}
		public JsonResult Add(Employee emp)
		{
			return Json(1, JsonRequestBehavior.AllowGet);
		}
		public JsonResult GetbyID(int ID)
		{
			var Employee = employees.Find(x => x.EmployeeID.Equals(ID));
			return Json(Employee, JsonRequestBehavior.AllowGet);
		}
		public JsonResult Update(Employee emp)
		{
			return Json(1, JsonRequestBehavior.AllowGet);
		}
		public JsonResult Delete(int ID)
		{
			return Json(1, JsonRequestBehavior.AllowGet);
		}
		public ActionResult Action01()
		{
			//return Redirect("Action02");
			//return RedirectToAction("Action02");
			return RedirectToAction("Index", "Users");
		}
		public ActionResult A()
		{
			return JavaScript("alert('hahahah')");
		}
		public ContentResult Action02()
		{
			return Content("uuu");
		}
		public ActionResult H5Demo()
		{
			//return View();
			var path = Server.MapPath("/Files/ADAEX.txt");
			return File(path, "application/x-zip-compressed");
		}
		[HttpPost]
		public JsonResult Lkey(Student stu)
		{
			var province = new Province();
			province.Location = stu.Name;
			province.Code = stu.Age;
			return Json(province, JsonRequestBehavior.AllowGet);
		}

		public ActionResult TableDemo()
		{
			return View(employees);
		}
	}
}