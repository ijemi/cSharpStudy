using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_json操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用litjson进行解析文本
            //两种引用litjson的方式
            //1.去litjson官网下载litjson.dll,然后添加引用，找到dll所在目录
            //2.右键引用，打开管理nuget包，在联机里搜索litjson，在搜索结果中选择一个，点击安装

            //List<Skill> skilllist = new List<Skill>();
            //我们使用JsonMapper去解析json文本
            //jsondata代表一个数组或者一个对象
            //JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("json技能信息.txt"));
            //foreach(JsonData temp in jsonData)//这里temp代表一个对象
            //{
            //    Skill skill = new Skill();
            //    JsonData idValue = temp["id"];//通过字符串索引器可以取得键值对的值
            //    JsonData nameValue = temp["name"];
            //    JsonData damageValue = temp["damage"];
            //    int id = Int32.Parse(idValue.ToString());
            //    int damage = Int32.Parse(damageValue.ToString());
            //    Console.Write(id + ":" + nameValue.ToString() + ":" + damage);
            //    skill.id = id;
            //    skill.damage = damage;
            //    skill.name = nameValue.ToString();
            //    skilllist.Add(skill);
            //}
            //foreach(var temp in skilllist)
            //{
            //    Console.WriteLine(temp);
            //}



            //使用泛型去解析json类型
            //json里面对象的健必须跟定义的类里面的字段或者属性保持一直
            //List<Skill> skilllist = new List<Skill>();
            //Skill[] skillArray= JsonMapper.ToObject<Skill[]>(File.ReadAllText("json技能信息.txt"));
            //foreach(var temp in skillArray)
            //{
            //    Console.WriteLine(temp);
            //}

            //List<Skill> skilllist = JsonMapper.ToObject<List<Skill>>(File.ReadAllText("json技能信息.txt"));
            //foreach (var temp in skilllist)
            //{
            //    Console.WriteLine(temp);
            //}


            //Player p= JsonMapper.ToObject<Player>(File.ReadAllText("主角信息.txt"));
            //Console.WriteLine(p);
            //foreach(var temp in p.SkillList)
            //{
            //    Console.WriteLine(temp);
            //}

            Player p = new Player();
            p.Name = "花千骨";
            p.Level = 100;
            p.Age = 16;
            string json= JsonMapper.ToJson(p);
            Console.WriteLine(json);

            //www.bejson.com      json校验网及在线编辑器
            Console.ReadKey();
        }
    }
}
