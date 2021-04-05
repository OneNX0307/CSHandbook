using OneNX.DesignPatten.FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.FactoryMethod.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			var factotryType = ConfigurationManager.AppSettings["FacttoryType"];
			var dllName = ConfigurationManager.AppSettings["DllName"];

			var currentAssembly = Assembly.GetExecutingAssembly();
			var codeBase = currentAssembly.CodeBase.ToLower().Replace(currentAssembly.ManifestModule.Name.ToLower(), string.Empty);
			var factoryAssembly = Assembly.LoadFrom(Path.Combine(codeBase, dllName));

			ICellphoneFactory cellphoneFactory = factoryAssembly.CreateInstance(factotryType) as ICellphoneFactory;

			var cellphone = cellphoneFactory.CrateCellphone();
			cellphone.Boot(); 
			Console.Read();
		}
	}
}
