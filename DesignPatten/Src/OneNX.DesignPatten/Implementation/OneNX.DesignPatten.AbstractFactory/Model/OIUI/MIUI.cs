using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Model.OIUI
{
	public class MIUI : UI
	{
		public override string Name => "MIUI";
		public override double Version => 12;
		public override double Score => 9;
	}
}
