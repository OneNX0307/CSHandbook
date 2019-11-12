using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFCallback.Contract;

namespace WCFCallback.Client
{
    public class Callback : ICallback
    {
        public void DoCallback(double a, double b, double result)
        {
            Console.WriteLine($"{a} + {b} = {result}");
        }
    }
}
