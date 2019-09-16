using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var masterList = new List<Martialmaster>()
            {
                new Martialmaster() {id = 1, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 1},
                new Martialmaster() {id = 2, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 9},
                new Martialmaster() {id = 3, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 10},
                new Martialmaster() {id = 4, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 11},
                new Martialmaster() {id = 5, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 1},
                new Martialmaster() {id = 6, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 12},
                new Martialmaster() {id = 7, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 1},
                new Martialmaster() {id = 8, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 10},
                new Martialmaster() {id = 9, Name = "黄蓉", Age = 18, MenPai = "丐帮", KongFU = "打狗棒法", Level = 1}
            };
            //初始化武学
            var kongfuList = new List<KongFu>()
            {
                new KongFu() {Id = 1, Name = "打狗棒法", Power = 90},
                new KongFu() {Id = 2, Name = "打狗棒法", Power = 90},
                new KongFu() {Id = 3, Name = "打狗棒法", Power = 90},
                new KongFu() {Id = 4, Name = "打狗棒法", Power = 90},
                new KongFu() {Id = 5, Name = "打狗棒法", Power = 90}
            };
            //查询所有武学级别大于8的武林高手
            //var res=new List<Martialmaster>();
            //foreach (var temp in masterList)
            //{
            //    if(temp.Level>8)
            //        res.Add(temp);
            //}

            //使用LINQ做查询（表达式写法）
            //var res = from m in masterList //from后面设置查询集合
            //    where m.Level > 8  && m.MenPai=="丐帮"//where后面跟上查询条件
            //    select m.Name;//表示m的结果返回

            //2扩展方法的写法
            //var res=masterList.Where(Test1);
            // foreach (var temp in res)
            // {
            //     Console.WriteLine(temp);
            // }
            //lamda表达式
            //var res = masterList.Where(m=>m.Level>8 && m.MenPai == "丐帮");
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}

            //取得所学功夫的水平大于8级的武林高手
            //3、LINQ联合查询
            //var res = from m in masterList
            //          from k in kongfuList
            //          where m.KongFU == k.Name && m.Level > 8
            //          //select new {master=m, kongfu = k};
            //          select m;
            //扩展方法用法
            //var res = masterList.SelectMany(m => kongfuList, (m, k) => new {master = m, kongfu = k}).Where(x =>
            //    x.master.KongFU == x.kongfu.Name && x.master.Level > 8);

            //4、对查询结果进行排序 orderby（descending倒序）
            //var res = from m in masterList //from后面设置查询集合
            //          where m.Level > 8 && m.MenPai == "丐帮"//where后面跟上查询条件
            //          orderby m.Age,m.Level descending 
            //          select m.Name;

            //var res = masterList.Where(m => m.Level > 8 && m.MenPai == "丐帮").OrderBy(m => m.Age);
            //var res = masterList.Where(m => m.Level > 8 && m.MenPai == "丐帮").OrderBy(m =>m.Level).ThenBy(m=>m.Age);


            //5 join on集合联合查询
            //var res = from m in masterList
            //          join k in kongfuList on m.KongFU equals k.Name
            //          where k.Power>=90
            //          select new { master = m, KongFu = k };

            //6、分组查询 into groups（把武林高手按照所学的功夫分类，看一下那个功夫修炼的人数最多）
            //var res = from k in kongfuList
            //          join m in masterList on k.Name equals m.KongFU
            //          into groups 
            //          orderby groups.Count()
            //          select new { kongfu = k, count=groups.Count() };

            //7、按照自身字段分组 group by
            //var res = from m in masterList
            //    group m by m.MenPai
            //    into g
            //    select new {count = g.Count(), g.Key};//g.key key表示是按照那个属性分的组


            //8、量词操作符any all 判断集合中是否满足某个条件
            //bool res=masterList.Any(m => m.MenPai == "丐帮");
            //Console.WriteLine(res);

            bool res=masterList.All(m => m.MenPai == "丐帮");
            Console.WriteLine(res);

            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}



            Console.ReadKey();
        }
        //过滤方法
        static bool Test1(Martialmaster master)
        {
            if (master.Level > 8) return true;
                return false;
        }
    }
}
