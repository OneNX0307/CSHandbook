using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroMQ;

namespace OneNX.ZMQ.QuickStart.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ZSocket request = new ZSocket(ZSocketType.REQ))
			{
				request.Connect("tcp://localhost:50000");
				Console.WriteLine($"Connect to server: tcp://localhost:50000");
				for (int i = 0; i < 10; i++)
				{
					string postStr = $"Lynn {i}";
					request.Send(new ZFrame(postStr));
					Console.WriteLine($"Post {postStr} to server....");

					using (ZFrame reply = request.ReceiveFrame())
					{
						Console.WriteLine($"Receive reply: {reply.ToString()}");
					}
				}
			}
			Console.Read();
		}
	}
}
