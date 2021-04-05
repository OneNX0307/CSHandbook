using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSync.AuoResetEventDemo
{
    class Program
    {
        //若要将初始状态设置为终止，则为 true；若要将初始状态设置为非终止，则为 false
        static AutoResetEvent oddResetEvent = new AutoResetEvent(false);
        static AutoResetEvent evenResetEvent = new AutoResetEvent(false);
        static int i = 0;
        static void Main(string[] args)
        {
            //ThreadStart是个委托
            Thread thread1 = new Thread(new ThreadStart(show));
            thread1.Name = "偶数线程";
            Thread thread2 = new Thread(new ThreadStart(show));
            thread2.Name = "奇数线程";
            thread1.Start();
            Thread.Sleep(2); //保证偶数线程先运行。
            thread2.Start();
            Console.Read();

        }
        public static void show()
        {
            while (i <= 100)
            {
                int num = i % 2;
                if (num == 0)
                {
                    Console.WriteLine("{0}:{1} {2}  ", Thread.CurrentThread.Name, i++, "evenResetEvent");
                    if (i != 1) evenResetEvent.Set();
                    oddResetEvent.WaitOne(); //当前线程阻塞

                }
                else
                {
                    Console.WriteLine("{0}:{1} {2} ", Thread.CurrentThread.Name, i++, "oddResetEvent");
                    //如果此时AutoResetEvent 为非终止状态，则线程会被阻止，并等待当前控制资源的线程通过调用 Set 来通知资源可用。否则不会被阻止
                    oddResetEvent.Set();
                    evenResetEvent.WaitOne();
                }
            }
        }
    }
}
