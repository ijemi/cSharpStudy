using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_事件
{//Event
    class Program
    {
        public delegate void MyDelegata();

        //public MyDelegata mydelegata;//声明了一个委托类型的变量，作为类的成员
        public event MyDelegata mydelegata;//声明了一个委托类型的变量，作为类的成员
        static void Main(string[] args)
        {
            Program program=new Program();
            program.mydelegata = Test1;
            program.mydelegata();
            Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("test1");
        }
    }
}
