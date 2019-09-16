using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace _030_xml操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建技能信息的集合，用来存储所有的技能信息
            List<Skill> skillList = new List<Skill>();

            //XmlDocument是专门解析xml文档的
            XmlDocument xmlDoc = new XmlDocument();
            //选择要加载解析的文档的名字
            //xmlDoc.Load("skillinfo.txt");
            xmlDoc.LoadXml(File.ReadAllText("skillinfo.txt"));//传递一个字符串（xml格式的字符串）

            //得到根节点(XmlNode用来代表一个节点)
            XmlNode rootNode = xmlDoc.FirstChild;//获得第一个节点
            //得到根节点下面的子节点的集合
            XmlNodeList skillNodeList= rootNode.ChildNodes;//获取当前节点下面的所有子节点

            foreach(XmlNode skillNode in skillNodeList)
            {
                Skill skill = new Skill();
                XmlNodeList fieltNodeList = skillNode.ChildNodes;//获取skill节点下面的所有节点
                foreach(XmlNode fieldNode in fieltNodeList)
                {
                    if(fieldNode.Name=="id")//通过name属性，可用获取一个节点的名字
                    {
                        int id=Int32.Parse(fieldNode.InnerText);//获取节点内部的文本
                        skill.id = id;
                    }
                    else if(fieldNode.Name=="name")
                    {
                        string name = fieldNode.InnerText;
                        skill.name = name;
                        skill.lang= fieldNode.Attributes[0].Value;
                    }
                    else
                    {
                        skill.damage = Int32.Parse(fieldNode.InnerText);
                    }
                }
                skillList.Add(skill);
            }
            foreach(Skill skill in skillList)
            {
                Console.WriteLine(skill);
            }
            Console.ReadKey();
        }
    }
}
