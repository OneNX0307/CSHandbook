using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDemo.CalculatorService.Contract;

namespace ClientWithCode
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<ICalculatorService> factory = new ChannelFactory<ICalculatorService>(new BasicHttpBinding(), "http://localhost:8888/ICalculatorService/"))
            {
                ICalculatorService proxy = factory.CreateChannel();
                Console.WriteLine(proxy.Add(5.0, 2.0));
                Console.WriteLine(proxy.Sub(5.0, 2.0));
                Console.WriteLine(proxy.Mul(5.0, 2.0));
                Console.WriteLine(proxy.Div(5.0, 2.0));
                Console.Read();
            };
        }
    }
}
