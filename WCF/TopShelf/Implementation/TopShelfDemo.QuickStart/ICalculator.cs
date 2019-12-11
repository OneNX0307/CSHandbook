using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopShelfDemo.QuickStart
{
    public interface ICalculator
    {
        double Add(double x, double y);
        void Start();
        void Stop();
    }
}
