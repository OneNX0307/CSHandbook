using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ReflectionDemo.Helper
{
    public static class ReflectionHelper
    {
        public static void PrintAllProperties(Type type)
        {
            PropertyInfo[] properties = type.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"Property: {property}");
            }
        }

        public static void PrintAllProperties(string assembllyPath)
        {
            var assembly = GetAssembly(assembllyPath);
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                var properties = type.GetProperties();
                foreach (var property in properties)
                {
                    Console.WriteLine($"Property: {property}");
                }
            }
        }

        public static void PrintAllMethods(Type type)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"Method: {method}");
            }
        }

        public static void PrintAllMethods(string assembllyPath)
        {
            var assembly = GetAssembly(assembllyPath);
             Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine($"Method: {method}");
                }
            }
        }

        public static void InvokeMethod(Type type, string methodName)
        {
            //method
            MethodInfo method = type.GetMethod(methodName, new Type[] { typeof(string)});
            //parameters
            ParameterInfo[] parameters = method.GetParameters();
            //return type
            var returnType = method.ReturnType;

            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Method: {method}");
            Console.WriteLine($"Parameters: {parameters}");
            Console.WriteLine($"Return type: {returnType}");
            Console.WriteLine($"{type}.{method.Name}({parameters})");
            //params
            object[] para = new object[] { "X" };
            //invoke
            object result;
            if (method.IsStatic)
            {
                result = type.InvokeMember(methodName, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, "AlfredXing", para);
            }
            else
            {
                result = method.Invoke("AlfredXing", para);
            }
            Console.WriteLine($"Result is {result}");
        }

        private static Assembly GetAssembly(string assembllyPath)
        {
            return Assembly.LoadFile(assembllyPath);
        }
    }
}
