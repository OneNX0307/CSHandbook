using OneNX.DesignPatten.FactoryMethod.Interface;
using OneNX.DesignPatten.FactoryMethod.Model.Cellphone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.FactoryMethod.Factory
{
	public class HuaweiFactory : ICellphoneFactory
	{
		public ICellphone CrateCellphone()
		{
			return new Huawei();
		}
	}
}
