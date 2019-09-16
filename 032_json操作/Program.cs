using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;

namespace _032_json操作
{
    class Program
    {
        static void Main(string[] args)
        {
           JsonData jsonData= JsonMapper.ToObject(File.ReadAllText("JSON技能信息.txt"));

        }
    }
}
