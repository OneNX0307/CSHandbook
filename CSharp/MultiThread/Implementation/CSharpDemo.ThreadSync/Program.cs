using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDemo.ThreadSync
{
    class Program
    {
        private static AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            //方法一：使用Thread创建线程运行
            //Thread thread = new Thread(Sing);
            //thread.Start();

            //方法二：实用Task在另一线程运行
            Task.Run(() => {
                Console.WriteLine("许仙：千年等一回~");
                Thread.Sleep(3000);
                autoResetEvent.Set();
            });

            autoResetEvent.WaitOne();
            Console.WriteLine("白娘子：等一回啊~啊~啊~");
            Console.Read();
        }

        private static void Sing()
        {
            Console.WriteLine("许仙：千年等一回~");
            Thread.Sleep(3000);
            autoResetEvent.Set();
        }
    }
}
