using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ServiceHost sh = new ServiceHost(typeof(CalculatorService)))
			{
				sh.AddServiceEndpoint(typeof(ICalculatorService), new WSHttpBinding(), "http://localhost:8888/ICalculatorService");
				sh.Opened += delegate
				{
					Console.WriteLine($"Service opened at: http://localhost:8888/ICalculatorService");
				};

				if (sh.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
				{
					ServiceMetadataBehavior metadataBehavior = new ServiceMetadataBehavior();
					metadataBehavior.HttpGetEnabled = true;
					metadataBehavior.HttpGetUrl = new Uri("http://localhost:8888/ICalculatorService/metadata");
					sh.Description.Behaviors.Add(metadataBehavior);
				}

				sh.Open();

				Console.Read();
			}
		}
	}
}
