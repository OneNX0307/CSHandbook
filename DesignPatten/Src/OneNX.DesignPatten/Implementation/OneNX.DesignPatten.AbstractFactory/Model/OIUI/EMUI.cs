using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.DesignPatten.AbstractFactory.Model.OIUI
{
	public class EMUI : UI
	{
		public override string Name => "EMUI";
		public override double Version => 10.1;
		public override double Score => 6.0;
	}
}
