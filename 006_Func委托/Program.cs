using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _006_Func委托
{
    //func必须有一个返回值
    class Program
    {
        static int Test1()
        {
            return 1;
        }

        static int Test2(string str)
        {
            Console.WriteLine(str);
            return 100;
        }

        static int Test3(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //Func<int> a=Test1;//func中的泛型类型指定的是方法的返回值类型 
            //Console.WriteLine(a());
            //Func<string, int> a = Test2;//func后面可以跟很多类型，最后一个类型是返回值类型，前面的类型是参数类型，参数类型必须跟指向的方法的参数类型，按照顺序对应
            Func<int, int, int> a=Test3;//func后面必须指定一个返回值类型，参数类型可以有0-16个，先写参数类型，最后一个返回值类型
            int res = a(1, 5);
            Console.WriteLine(res);


            DateTime times=DateTime.Now;
            string hm = times.ToString("HH:mm");
            Console.WriteLine(hm);
            Console.ReadKey();


        }
    }
}
