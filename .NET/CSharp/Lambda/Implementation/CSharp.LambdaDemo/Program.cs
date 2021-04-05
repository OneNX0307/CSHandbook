using CSharp.LambdaDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = LambdaHelper.ModifyName("SMEE", name => 
            {
                string newName = string.Empty;
                newName = "上微";
                return newName;
            });
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
