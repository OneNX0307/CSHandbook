using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroMQ;

namespace OneNX.ZMQ.QuickStart.Server
{
	class Program
	{
		static void Main(string[] args)
		{
			string url = "tcp://*:50000";
			using (ZSocket receiver = new ZSocket(ZSocketType.REP))
			{
				receiver.Bind(url);
				Console.WriteLine($"Server is binding to {url}");

				while (true)
				{
					using (ZFrame message = receiver.ReceiveFrame())
					{
						Console.WriteLine($"Receive message {message.ToString()}");
						var reply = new ZFrame("Lynn");
						Console.WriteLine($"Send reply: {reply.ToString()}");
						receiver.Send(reply);
					};
				}
				
			};
		}
	}
}
