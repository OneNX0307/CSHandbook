using OneNX.DesignPatten.AbstractFactory.Model.Cellphone;
using OneNX.DesignPatten.AbstractFactory.Model.OIUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Factory
{
	public abstract class ProductFactory
	{
		public abstract Cellphone CreateCellphone();
		public abstract UI CreateUI();
	}
}
