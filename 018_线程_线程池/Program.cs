using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _018_线程_线程池//使用与小任务
{
    class Program
    {
        static void ThreadMethod(object state)
        {
            Console.WriteLine("线程开始:"+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("线程结束");
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            Console.ReadKey();
        }
    }
}
