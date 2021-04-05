using OneNX.DesignPatten.FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.FactoryMethod.Model.Cellphone
{
	public class Meizu : ICellphone
	{
		public void Boot()
		{
			Console.WriteLine($"Meizu booting...");
		}
	}
}
