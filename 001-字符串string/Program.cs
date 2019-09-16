using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_字符串string
{
    class Program
    {
        static void Main(string[] args)
        {
            //string类型是不可变的数据类型一旦初始化，内容就不能改变了，从新更改给定的字符串，实际上是
            //创建了一个新的字符串，把老的字符串复制过来，重复修改，效率会更低

            //string s = "www.baidu.com";//创建字符串，使用string类型存储字符串类型，字符串需要使用双引号引起来
            //int length = s.Length;//获取字符串长度
            //Console.Write(length);

            //比较字符串是否一样
            //if (s == "xxx") { 
            //    Console.Write("相同");
            //}
            //else { 
            //    Console.Write("不    相同");
            //}

            //字符串连接
            //s = "Http://" + s;
            //Console.Write(s);

            //使用类似索引器的语法来取得字符串中某个字符
            //char c = s[2];
            //Console.WriteLine(c);

            //for(int i=0;i<s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            //比较字符串的内容
            //string s = "siki";
            //int result= s.CompareTo("siki");//当两个字符串相等的时候，返回0；当s在字母表中排序靠前的时候，
            ////返回-1；否则返回1
            //Console.Write(result);

            //用另外一个字符或字符串替换字符串中给定的字符或字符串
            //string newStr=s.Replace(".", "-");
            //string newStr = s.Replace(".", "-----");//把指定字符换成指定字符
            //Console.WriteLine(s);
            //Console.WriteLine(newStr);

            //string s = "www.baidu.com";
            //在出项给定字符串的地方，把字符串拆分成字符串数组
            //string[] strArray = s.Split('.');
            //foreach(var temp in strArray)
            //{
            //    Console.WriteLine(temp);
            //}

            //在字符串中检索给定位置的子字符串
            //string str= s.Substring(4, 9);//9不写，就是截至到最后
            //Console.WriteLine(str);

            //转换成大写
            //string str= s.ToUpper();//大写
            //string str = s.ToLower();//小写
            //Console.WriteLine(str);



            //删除首位空白
            //string s = " www.baidu.com ";
            //string str=s.Trim();
            //Console.WriteLine(str);

            //string s = "www.baidu.com";//string是System.String的别名

            //我们可以使用这个方法判断当前字符串是否包含子字符串，如果不包含，返回-1，如果包含会返回第一个字符串的索引
            //int index=s.IndexOf("baidu");
            //Console.WriteLine(index);

            //Concat() 合并字符串
            //CopyTo() 把字符串中指定的字符复制到一个数组中
            //Format() 格式化字符串 
            //Insert() 把一个字符串实例插入另一个字符串实例的制定索引处
            //Join() 合并字符串数组，创建一个新字符串

            Console.ReadKey();
        }
    }
}
