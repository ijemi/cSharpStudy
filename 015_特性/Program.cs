#define IsTest//定义一个宏

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _015_特性
{
    //通过指定属性的名字，给属性赋值，这种是命名参数
    [MyTest("简单的特性类",ID = 100)]//当我们使用特性的时候，后面的Attribute不需要写
    class Program
    {
        [Obsolete("这个方法过时了，使用NewMethod代替",true)]//obsolete特性用来表示一个方法被弃用了
        static void OldMethod()
        {
            Console.WriteLine("OldMethod");
        }
        static void NewMethod()
        {
            Console.WriteLine("NewMethod");
        }


        [Conditional("IsTest")]//包括或取消所有特定方法的调用
        static void Test1()
        {
            Console.WriteLine("Test1");
        }
        static void Test2()
        {
            Console.WriteLine("Test2");
        }

        [DebuggerStepThrough]//可以跳过debugger的单步调试，不让进去该方法（当我们确定这个方法没有错误的时候）
        static void PrintOut(string str,[CallerFilePath] string fillName="",[CallerLineNumber]
            int lineNumber=0,[CallerMemberName] string methodName="")
        {
            Console.WriteLine(str);
            Console.WriteLine(fillName);
            Console.WriteLine(lineNumber);
            Console.WriteLine(methodName);

        }
        static void Main(string[] args)
        {
            //NewMethod();
            //OldMethod();
            //Console.ReadKey();


            //Test1();
            //Test2();
            //Test1();


            //PrintOut("123");


            Type type = typeof(Program);//通过typeof+类名也可以获得type对象
            object[] res= type.GetCustomAttributes(false);
            MyTestAttribute test= res[0] as MyTestAttribute;
            Console.WriteLine(test.Description);
            Console.WriteLine(test.ID);
            Console.ReadKey();
        }
    }
}
