using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFCallback.Contract;

namespace WCFCallback.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new Callback());
            using (DuplexChannelFactory<ICalculator> factory = new DuplexChannelFactory<ICalculator>(instanceContext, "CalculatorService"))
            {
                ICalculator proxy = factory.CreateChannel(instanceContext);
                proxy.Add(1, 2);
                Console.Read();
            }
        }
    }
}
