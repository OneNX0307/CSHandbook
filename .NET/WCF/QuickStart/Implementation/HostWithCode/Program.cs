using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCFDemo.CalculatorService.Contract;
using WCFDemo.CalculatorService.Implementation;

namespace HostWithCode
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {

                host.AddServiceEndpoint(typeof(ICalculatorService), new BasicHttpBinding(), "http://localhost:8888/ICalculatorService/");
                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = new Uri(@"http://localhost:8888/ICalculatorService/metadata");
                    host.Description.Behaviors.Add(behavior);
                }
                host.Opened += delegate
                {
                    Console.WriteLine("=================================================");
                    Console.WriteLine("CalculatorService has been opend at: ");
                    Console.WriteLine("http://localhost:8888/ICalculatorService/");
                    Console.WriteLine("=================================================");
                    Console.WriteLine("CalculatorService metadata at: ");
                    Console.WriteLine("http://localhost:8888/ICalculatorService/metadata");
                    Console.WriteLine("=================================================");
                };
                host.Open();
                Console.Read();
            }
        }
    }
}
