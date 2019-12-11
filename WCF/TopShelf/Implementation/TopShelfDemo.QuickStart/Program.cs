using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TopShelfDemo.QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<ICalculator>(s => {
                    s.ConstructUsing(name => new Calculator());
                    s.WhenStarted(cal => cal.Start());
                    s.WhenStopped(cal => cal.Stop());
                });

                x.RunAsLocalSystem();

                x.SetDescription("Calculator service");
                x.SetDisplayName("CalculatorService");
                x.SetServiceName("CalculatorService");
            });
        }
    }
}
