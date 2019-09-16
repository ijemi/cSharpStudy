using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_使用File读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
           //string[] strArray= File.ReadAllLines("TextFile1.txt");//读取文件把每一行文本读取成一个字符串，最后组成一个字符串的数组
           //foreach (var s in strArray)
           //{
           //    Console.WriteLine(s);
           //}

           //string s = File.ReadAllText("TextFile1.txt");
           //Console.WriteLine(s);

           //byte[] byteArray= File.ReadAllBytes("SBJCtop1.png");
           //foreach (var s in byteArray)
           //{
           //    Console.WriteLine(s);
           //}

           //File.WriteAllText("textfile2.txt","你好中国");

           //File.WriteAllLines("textfile3.txt",new string[]{"asdad","sdasda","123"});

           byte[] data = File.ReadAllBytes("SBJCtop1.png");
           File.WriteAllBytes("4.png",data);


           Console.ReadKey();
        }
    }
}
