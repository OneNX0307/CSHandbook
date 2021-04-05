using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Overview.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ChannelFactory<ICalculatorService> factory = new ChannelFactory<ICalculatorService>(new WSHttpBinding(), "http://localhost:8888/ICalculatorService"))
			{
				ICalculatorService proxy = factory.CreateChannel();
				var result = proxy.Add(1.1, 2.2);
			}

			Console.Read();
		}
	}
}
