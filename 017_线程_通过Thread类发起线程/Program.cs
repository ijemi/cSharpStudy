using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _017_线程_通过Thread类发起线程
{
    class Program
    {
        static void DownLoadFile(object filename)
        {
            Console.WriteLine("开始下载:"+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("下载完成");
        }
        static void Main(string[] args)
        {
            //Thread t=new Thread(DownLoadFile);//创建出来Thread对象，这个线程并没有启动
            //t.Start();//开始，开始去执行线程
            //Console.WriteLine("main");

            //lambda表达式
            //Thread t = new Thread(() =>
            //{
            //    Console.WriteLine("开始下载:" + Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(1000);
            //    Console.WriteLine("下载完成");
            //});
            //t.Start();


            //传递数据
            //Thread t = new Thread(DownLoadFile);//创建出来Thread对象，这个线程并没有启动
            //t.Start("xxx.种子");//开始，开始去执行线程
            //Console.WriteLine("main");

            //MyThread my=new MyThread("xxx.种子","http://www.baidu.com");
            //Thread t= new Thread(my.DownFile);//我们构造一个thread对象的时候，可以传递一个静态方法，
            //                                  //也可以传递一个对象的普通方法
            //t.Start();



            //Thread t=new Thread(DownLoadFile);//这是个前台线程
            Thread t = new Thread(DownLoadFile);//这是个前台线程
            t.IsBackground = true;//设置为后台线程
            t.Start("xx");
            t.Abort();//终止这个线程的执行
            t.Join();//让当前线程睡眠，等待线程执行完，然后继续运行下面的代码

            Console.ReadKey();
        }
    }
}
