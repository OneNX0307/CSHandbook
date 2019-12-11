using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LambdaDemo.Helper
{
    public static class LambdaHelper
    {
        public static string ModifyName(string name, Func<string, string> func)
        {
            return func(name);
        }
    }
}
