using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDemo.MultiThread
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Create thread

			#region Thread
			//ThreadStart with method
			Thread thread01A = new Thread(new ThreadStart(Thread01AHandler));
			thread01A.Start();
			//Thread with lambda
			Thread thread01B = new Thread(() => Console.WriteLine($"ThreadStart with lambda."));
			thread01B.Start();
			//ParameterizedThreadStart with method
			Thread thread02A = new Thread(new ParameterizedThreadStart(ThreadWithParamAHandler));
			thread02A.Start("Alfred");
			//ParameterizedThreadStart with lambda
			Thread thread02B = new Thread(x => Console.WriteLine($"ParameterizedThreadStart with param {x}"));
			thread02B.Start();
			#endregion

			#region Task
			Task task01A = new Task(TaskHandler01A);
			task01A.Start();
			Task task01B = new Task(() => Console.WriteLine($"Create task with lambda."));
			task01B.Start();
			Task task02A = new Task(TaskHandler02A, "Task with method.");
			task02A.Start();
			Task task02B = new Task(x => Console.WriteLine(x), "Task in param with lambda.");
			task02B.Start();
			Task.Run(() => Console.WriteLine("Task run..."));
			Task<string> task03 = Task.Run<string>(() => "Lynn");
			Console.WriteLine(task03.Result);
			#endregion

			#region TaskFactory
			TaskFactory factory = new TaskFactory();
			Task task03A = factory.StartNew(TaskHandler03A);
			Task task03B = factory.StartNew(() => Console.WriteLine("Task created with factory with lambda."));
			Task task04A = factory.StartNew(TaskHandler04A, "04A");
			Task task04B = factory.StartNew(x => Console.WriteLine((string)x), "04B");

			Task task04C = Task.Factory.StartNew(() => Console.WriteLine("Task with Task.Factory.StartNew..."));
			#endregion

			#region Task with a return
			Task<string> task05A = factory.StartNew<string>(TaskWithReturn);
			Console.WriteLine(task05A.Result);
			Task<string> task05B = new Task<string>(() => "Hello");
			task05B.Start();
			Console.WriteLine(task05B.Result);

			#endregion

			#endregion

			#region Thraed Synchronize 

			#region Inner process

			#region 1. lock
			
			#endregion

			#region 2. InterLocked

			#endregion

			#region 3. Monitor

			#endregion

			#endregion

			#region Inter process

			#region 1. WaitHandle

			#endregion

			#region 2. Mutex

			#endregion

			#region 3. Semaphore

			#endregion

			#region 4. AutoResetEvent 

			#endregion

			#region 5. ManualResetEvent

			#endregion

			#endregion

			#endregion

			#region Foreground and background

			#endregion

			#region UIThread

			#endregion

			Console.ReadLine();
		}

		#region Private methods
		private static void Thread01AHandler()
		{
			Console.WriteLine("Thread01AHandler invoked.");
		}
		private static void ThreadWithParamAHandler(object obj)
		{
			Console.WriteLine($"Thread with param handler A, param is {obj.ToString()}");
		}
		private static void TaskHandler01A()
		{
			Console.WriteLine($"Crate task with method.");
		}
		private static void TaskHandler02A(object obj)
		{
			Console.WriteLine((string)obj);
		}
		private static string TaskWithReturn()
		{
			return "Alfred";
		}
		private static void TaskHandler04A(object obj)
		{
			Console.WriteLine((string)obj);
		}
		private static void TaskHandler03A()
		{
			Console.WriteLine("TaskHandler03A");
		}
		#endregion
	}
}
