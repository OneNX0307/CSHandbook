using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFDemo.Animal
{
	[Export(typeof(IAnimal))]
	public class Dog : IAnimal
	{
		public void Run()
		{
			Console.WriteLine("Dog run...");
		}
	}
}
