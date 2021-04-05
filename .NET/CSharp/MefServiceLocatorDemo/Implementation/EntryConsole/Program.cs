using CommonServiceLocator;
using MefContainer;
using Models;
using System;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace ConsoleApp17
{
	class Program
	{
		static void Main(string[] args)
		{
			DirectoryCatalog Catalog = new DirectoryCatalog(Environment.CurrentDirectory);
			MefCompositionContainer container = new MefCompositionContainer(Catalog);
			try
			{
				container.Config();
			}
			catch (Exception e)
			{
				throw e;
			}

			//Get
			var instances = ServiceLocator.Current.GetAllInstances(typeof(IAnimal));
			foreach (var instance in instances)
			{
				Console.WriteLine(instance.ToString());
			}

			var dog = ServiceLocator.Current.GetInstance<IAnimal>();
			var serviceLocator = ServiceLocator.Current.GetInstance<IServiceLocator>();
			var mefContainer01 = ServiceLocator.Current.GetInstance<MefCompositionContainer>();
			var mefContainer02 = ServiceLocator.Current.GetInstance<ICompositionContainer>();
			if (mefContainer01.GetHashCode() == mefContainer02.GetHashCode())
			{
				Console.WriteLine("Same");
			}

			Console.Read();
		}
	}
}
