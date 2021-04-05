using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDemo.CalculatorService.Implementation;

namespace HostWithConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Opened += delegate
                {
                    Console.WriteLine("=================================================");
                    Console.WriteLine("CalculatorService has been opend at:");
                    Console.WriteLine("http://localhost:8888/ICalculatorService/");
                    Console.WriteLine("=================================================");
                    Console.WriteLine("CalculatorService metadata at:");
                    Console.WriteLine("http://localhost:8888/ICalculatorService/metadata");
                    Console.WriteLine("=================================================");
                };
                host.Open();
                Console.Read();
            }
        }
    }
}
