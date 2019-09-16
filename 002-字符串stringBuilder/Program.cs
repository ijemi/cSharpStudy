using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_字符串StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder的命名空间是:System.Text
            //1种创建方式
            //StringBuilder sb = new StringBuilder("www.baidu.com");//利用构造函数创建stringBuilder
            //2种创建方式
            //StringBuilder sb = new StringBuilder(20);//初始一个空的string builder，占有20个字符的大小
            //3种创建方式
            //StringBuilder sb = new StringBuilder("www.baidu.com", 100);

            //stringbuilder的字符串连接
            //StringBuilder sb = new StringBuilder("www.baidu.com", 100);
            //sb.Append("/xxx.html");//给当前字符串增加一个字符
            //Console.WriteLine(sb.ToString());

            //string的字符串连接
            //string s = "www.baidu.com";
            //s = s + "/xxx.html";
            //Console.WriteLine(s);

            //string和stringbuilder的区别：，当我们需要对一个字符串进行频繁的删除添加操作的时候，使用stringbuilder的效率更高

            StringBuilder sb = new StringBuilder("www.baidu.com", 100);

            //增加特定格式的字符串
            //sb.Insert(0, "http://");
            //Console.WriteLine(sb);

            //从当前字符串中删除字符
            //sb.Remove(0, 4);
            //Console.WriteLine(sb);

            //在当前字符串中，用某个字符或字符串全部替换另一个字符或字符串
            //sb.Replace(".", "-");
            //Console.WriteLine(sb);

            //ToString() 在当前stringbuilder中存储的字符串，提取成一个不可变的字符串



            Console.ReadKey();
        }
    }
}
