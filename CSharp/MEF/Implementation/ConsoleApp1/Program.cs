using MEFDemo;
using MEFDemo.Entry;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Mef mef = new Mef();
			mef.Config();

			mef.Cat.Run();

			mef.Kitty.Value.Run();

			foreach (var animal in mef.Animals)
			{
				animal.Run();
			}

			Console.WriteLine($"The little pig a {mef.Age} years old.");
			Console.WriteLine($"Owner is {mef.Owner}");

			mef.Run();

			var info = mef.GetInfo("Alfred Xing");
			Console.WriteLine(info);
			Console.Read();
		}
	}
}
