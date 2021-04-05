using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFDemo.Animal
{
	[Export(typeof(IAnimal))]
	public class Rabbit : IAnimal
	{
		public void Run()
		{
			Console.WriteLine("Rabbit run...");
		}
	}
}
