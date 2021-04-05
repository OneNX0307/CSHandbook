using OneNX.DesignPatten.AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Model.Cellphone
{
	public class Xiaomi : Cellphone
	{
		public override CellphoneBrandEnum Brand => CellphoneBrandEnum.Xiaomi;
		public void Boot()
		{
			Console.WriteLine($"Xiaomi booting...");
		}
	}
}
