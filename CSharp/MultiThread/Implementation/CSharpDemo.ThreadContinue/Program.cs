using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDemo.ThreadContinue
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Task> tasks = new List<Task>()
			{
				Task.Factory.StartNew(() => {
					Console.WriteLine("Start to doing English homework....");
					Thread.Sleep(3000);
					Console.WriteLine("English homework has done!");
				}),

				Task.Factory.StartNew(() => {
					Console.WriteLine("Start to doing Chinese homework....");
					Thread.Sleep(4000);
					Console.WriteLine("Chinese homework has done!");
				}),

				Task.Factory.StartNew(() => {
					Console.WriteLine("Start to doing Math homework....");
					Thread.Sleep(5000);
					Console.WriteLine("Math homework has done!");
				}),

				Task.Factory.StartNew(() => {
					Console.WriteLine("Start to doing Art homework....");
					Thread.Sleep(6000);
					Console.WriteLine("Art homework has done!");
				}),
		};

			Task.WhenAll(tasks.ToArray()).ContinueWith(x => {
				Console.WriteLine("All homework has done!");
				Console.WriteLine("You can to watch TV!");
			});

			Console.Read();
		}
	}
}
