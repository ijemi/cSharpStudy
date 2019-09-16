using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_委托
{
    public class Program
    {
        private delegate string GetAString();//定义了一个委托类型，这个委托类型的名字叫做GetAString
        static void Main(string[] args)
        {
            //定义委托
            //delegate void IntMethodInvoker(int x);

            //int x = 40;
            //string s=x.ToString();//tostring方法用来把数据转化成字符串
            //Console.WriteLine(s);
            //使用委托创建实例
            //GetAString a = new GetAString(x.ToString);//a指向了x中的tostring方法，第一种方法，初始化委托的方式
            //GetAString a = x.ToString;//初始化第二种方法，常用的

            //string s = a();//通过委托实例去调用x中的tostring方法，第一张调用方法，常用的
            //string s = a.Invoke();//通过invoke方法调用a所引用的方法，第二种调用方法
            //Console.WriteLine(s);//通过委托类型调用一个方法，跟直接调用这个方法是一样的


            //实例2 使用委托类型作为方法的参数
            PrintString method=Method1;
            PrintStr(method);
            method = Method2;
            PrintStr(method);
            Console.ReadKey();
        }

        private delegate void PrintString();

        static void PrintStr(PrintString print)//普通方法
        {
            print();
        }

        static void Method1()//静态方法
        {
            Console.WriteLine("method1");
        }
        static void Method2()
        {
            Console.WriteLine("method2");
        }
    }
}
