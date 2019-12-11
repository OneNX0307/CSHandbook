using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopShelfDemo.QuickStart
{
    public class Calculator : ICalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public void Start()
        {
            Console.WriteLine("Start....");
        }

        public void Stop()
        {
            Console.WriteLine("Stop....");
        }
    }
}
