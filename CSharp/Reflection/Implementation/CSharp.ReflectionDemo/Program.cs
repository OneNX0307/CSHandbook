using CSharp.ReflectionDemo.Helper;
using CSharp.ReflectionDemo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PropertyInfoDemo();
            //ReflectionHelper.PrintAllMethods(@"D:\Workspace\.NET\CSHandbook\WPF\DependencyProperty\Implementation\bin\Debug\WPF.DependencyPropertyDemo.exe");
            //静态方法
            //ReflectionHelper.InvokeMethod(typeof(string), "Contains");
            //实例方法
            //ReflectionHelper.InvokeMethod(typeof(string), "IndexOf");
            //无参
            var book01 = Activator.CreateInstance(typeof(Book));
            //一个参数
            var book02 = Activator.CreateInstance(typeof(Book), 1);
            //两个参数
            var book03 = Activator.CreateInstance(typeof(Book), 1, "Flipped") as Book;
            Console.Read();
        }

        static void PropertyInfoDemo()
        {
            PropertyInfo len = typeof(string).GetProperty("Length");
            string s = "Hello,reflection!";
            int length = (int)len.GetValue(s, null);
            Console.WriteLine(length.ToString());
        }
    }
}
