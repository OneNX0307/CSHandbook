using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	[Export(typeof(IAnimal))]
	public class Cat : IAnimal
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public void Run()
		{
			Console.WriteLine($"Cat {Name} Running");
		}
	}
}
