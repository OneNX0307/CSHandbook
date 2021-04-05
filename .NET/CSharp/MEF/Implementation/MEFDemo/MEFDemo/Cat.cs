using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFDemo.Animal
{
	[Export("Cat", typeof(IAnimal))]
	public class Cat : IAnimal
	{
		public void Run()
		{
			Console.WriteLine("Cat run...");
		}
	}
}
