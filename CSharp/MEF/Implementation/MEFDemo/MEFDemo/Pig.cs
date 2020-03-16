using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEFDemo.Animal
{
	public class Pig : IAnimal
	{
		[Export("Owner")]
		public string Owner { get; set; } = "Lynn";

		[Export("Age")]
		public int Age = 4;

		[Export("Run")]
		public void Run()
		{
			System.Console.WriteLine("Pig run...");
		}

		[Export("GetInfo")]
		public string GetInfo(string info)
		{
			return $"Hello, {info}.";
		}
	}
}
