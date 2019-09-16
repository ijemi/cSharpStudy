using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _014_反射和特性
{
    class Program
    {
        static void Main(string[] args)
        {
            //每一个类对应一个Type对象，这个Type对象存储了这个类有哪些方法跟那些成员
            //MyClass my=new MyClass();//一个类中数据式存储在对象中的，但是Type对象只存储类的成员
            //Type type = my.GetType();//通过对象获取这个对象的所属类的Type对象
            //Console.WriteLine(type.Name);//获取类的名字
            //Console.WriteLine(type.Namespace);//获取所在的命名空间
            //Console.WriteLine(type.Assembly);//程序集
            //FieldInfo[] array = type.GetFields();//只能获取public字段
            //foreach (FieldInfo info in array)
            //{
            //    Console.Write(info.Name+" ");
            //}

            //PropertyInfo[] array2 = type.GetProperties();
            //foreach (PropertyInfo info in array2)
            //{
            //    Console.Write(info.Name + " ");
            //}

            //MethodInfo[] array3 = type.GetMethods();
            //foreach (MethodInfo info in array3)
            //{
            // Console.Write(info.Name+" ");   
            //}
            //通过Type对象可以获取它所有的public成员


            MyClass my=new MyClass();
            Assembly assem= my.GetType().Assembly;//通过类的Type对象获取它所在的程序集Assembly
            Console.WriteLine(assem.FullName);
            Type[] types= assem.GetTypes();//类名
            foreach (var type in types)
            {
                Console.WriteLine(type);
            }
            Console.ReadKey();
        }
    }
}
