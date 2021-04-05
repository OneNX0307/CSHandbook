using OneNX.DesignPatten.AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Model.Cellphone
{
	public class Huawei : Cellphone
	{
		public override CellphoneBrandEnum Brand => CellphoneBrandEnum.Huawei;
		public void Boot()
		{
			Console.WriteLine($"Huawei booting...");
		}
	}
}
