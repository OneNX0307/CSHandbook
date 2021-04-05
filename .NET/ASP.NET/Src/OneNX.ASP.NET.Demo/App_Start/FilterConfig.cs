using OneNX.ASP.NET.Demo.CustomAttributes;
using System.Web;
using System.Web.Mvc;

namespace OneNX.ASP.NET.Demo
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			//filters.Add(new HandleErrorAttribute());
			//filters.Add(new MyAuthorization());
			filters.Add(new MyException());
		}
	}
}
