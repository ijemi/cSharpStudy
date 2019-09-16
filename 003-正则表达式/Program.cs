using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _003_正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //定位元字符^ $
            //string s = "I am blue cat.";
            //匹配开始
            //搜索字符串 符合正则表达式的情况，然后把所有符合的位置，替换成后面的字符
            //string res = Regex.Replace(s, "^", "开始：");
            //Console.WriteLine(res);
            //匹配结束
            //string res = Regex.Replace(s, "$", "结束");
            //Console.WriteLine(res);

            //校验只允许输入数字
            //string s = Console.ReadLine();
            //bool isMatch = true;//默认标识位，标识s是一个合法的密码（全部是数字）
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] < '0' || s[i] > '9') //当前字符如果不是数字字符
            //    {
            //        isMatch = false;
            //        break;
            //    }
            //}
            //if (isMatch)
            //{   
            //    Console.WriteLine("是一个合法密码");
            //}
            //else
            //{
            //    Console.WriteLine("不是一个合法密码");
            //}
            //正则表达式
            //string pattern = @"^\d*$";
            //bool isMatch= Regex.IsMatch(s, pattarn);
            //Console.WriteLine(isMatch);

            //校验只允许输入大小写字母、0-9的数字、下划线——以外的任何字
            //string pattarn = @"^\W*$";
            //bool isMatch = Regex.IsMatch(s, pattarn);
            //Console.WriteLine(isMatch);

            //***基本语法元字符
            //\w匹配字母、数字、下划线、汉字
            //\W匹配除（字母、数字、下划线、汉字）以外
            //\s匹配任意空白字符
            //\S匹配\s定义的字符以外
            //\d匹配数字
            //\D匹配数字以外


            //反义字符
            //\W
            //\S
            //\D
            //\B匹配不是单词开头或结束的位置
            //[abc]匹配中括号中的字符
            //[a-c]a到c之间是字符
            //[^x]匹配除了x以外的字符
            //[^adws]匹配除adwsx以外的任意字符


            //查找除ahou这之外的所有字符
            //string str = "I am blue cat.";
            //string pattarn = @"[^ahou]";
            //string s= Regex.Replace(str, pattarn,"*");
            //Console.WriteLine(s);


            //重复表述字符
            //(n)匹配前面的字符n次
            //(n,)匹配前面的字符n次或多余n次
            //(n,m)匹配前面的字符n到m次
            //?重复0次或一次
            //+重复一次或更多次
            //*重复零次或更多次

            //校验输入的内容是否是合法的QQ号（5-12位的数字）
            //string qq1 = "123456";
            //string qq2 = "67753736834987392688979";
            //string qq3 = "shh7788";
            //string pattarn = @"^\d{5,12}$";
            //Console.WriteLine(Regex.IsMatch(qq1,pattarn));
            //Console.WriteLine(Regex.IsMatch(qq2, pattarn));
            //Console.WriteLine(Regex.IsMatch(qq3, pattarn));



            //择一匹配(|)
            //两个匹配条件进行或运算

            //查找字符中数字或字母
            //string s = "34gajjjk高绘****8";
            //string pattarn = @"/d|[a-z]";
            //MatchCollection col=Regex.Matches(s, pattarn);
            //foreach (Match match in col)
            //{
            //    Console.WriteLine(match.ToString());//嗲用tostring方法，会输出所有匹配字符串
            //}

            //输出一个人名
            //String s = "zhangsan;lisi;wangwu;zholiu";
            ////string pattarn = @"[;;;]";
            //string pattarn = @"[;]|[;]|[;]";
            //string[] resArray= Regex.Split(s, pattarn);
            //foreach (var s1 in resArray)
            //{
            //    Console.WriteLine(s1);
            //}



            //正则表达式分组
            //重复多个字符，使用（abcd）{n}进行分组限定
            //string inputStr = Console.ReadLine();
            //string strGroup2 = @"(ab\w{2}){2}"; //(ab\w{ 2}){ 2}=ab\w{ 2}ab\w{ 2}
            //Console.WriteLine("分组字符重复两次替换为5555，结果为：" + 
            //                  Regex.Replace(inputStr, strGroup2, "5555"));



            //校验IP4地址
            //@"^(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d|?))$"





            Console.ReadKey();
        }
    }
}
