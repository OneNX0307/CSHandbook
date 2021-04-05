using OneNX.DesignPatten.SimpleFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.SimpleFactory.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			CellphoneFactory factory = new CellphoneFactory();

			var xiaomi = factory.GetCellPhone(Enum.CellphoneBrandEnum.Xiaomi);
			xiaomi.Boot();

			var meizu = factory.GetCellPhone(Enum.CellphoneBrandEnum.Meizu);
			meizu.Boot();

			var huawei = factory.GetCellPhone(Enum.CellphoneBrandEnum.Huawei);
			huawei.Boot();

			Console.Read();
		}
	}
}
