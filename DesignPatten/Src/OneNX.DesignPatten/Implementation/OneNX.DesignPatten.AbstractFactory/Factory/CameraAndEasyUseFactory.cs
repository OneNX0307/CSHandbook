using OneNX.DesignPatten.AbstractFactory.Model.Cellphone;
using OneNX.DesignPatten.AbstractFactory.Model.OIUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Factory
{
	public class CameraAndEasyUseFactory : ProductFactory
	{
		public override Cellphone CreateCellphone()
		{
			return new Huawei();
		}

		public override UI CreateUI()
		{
			return new MIUI();
		}
	}
}
