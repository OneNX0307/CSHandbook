using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNX.Logging4net
{
	class Program
	{
		static ILog logger = LogManager.GetLogger(typeof(Program));

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			logger.Error("Error message!");
			Console.Read();
		}
	}
}
