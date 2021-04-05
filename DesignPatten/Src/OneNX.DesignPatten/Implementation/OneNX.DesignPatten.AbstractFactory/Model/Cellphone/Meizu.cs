using OneNX.DesignPatten.AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Model.Cellphone
{
	public class Meizu : Cellphone
	{
		public override CellphoneBrandEnum Brand => CellphoneBrandEnum.Meizu;
		public void Boot()
		{
			Console.WriteLine($"Meizu booting...");
		}
	}
}
