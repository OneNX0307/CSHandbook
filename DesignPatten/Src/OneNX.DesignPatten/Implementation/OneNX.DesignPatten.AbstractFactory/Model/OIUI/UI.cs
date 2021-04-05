using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Model.OIUI
{
	public abstract class UI
	{
		public abstract string Name { get; }
		public abstract double Version { get; }
		public abstract double Score { get; }
	}
}
