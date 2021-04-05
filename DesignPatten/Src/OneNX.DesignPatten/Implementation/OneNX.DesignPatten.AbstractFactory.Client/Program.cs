using OneNX.DesignPatten.AbstractFactory.Factory;
using OneNX.DesignPatten.AbstractFactory.Model.Cellphone;
using OneNX.DesignPatten.AbstractFactory.Model.OIUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			

			var cellphoneFactory = ConfigurationManager.AppSettings["CellphoneFactory"];
			var dllName = ConfigurationManager.AppSettings["DllName"];
			var currentAssembly = Assembly.GetExecutingAssembly();
			var codeBase = currentAssembly.CodeBase.ToLower().Replace(currentAssembly.ManifestModule.Name.ToLower(), string.Empty);

			var factoryAssembly = Assembly.LoadFrom(Path.Combine(codeBase, dllName));
			ProductFactory productFactory = factoryAssembly.CreateInstance(cellphoneFactory) as ProductFactory;
			Cellphone cellphone = productFactory.CreateCellphone();
			UI ui = productFactory.CreateUI();
			cellphone.WrapUI(ui);

			Console.Read();
		}
	}
}
