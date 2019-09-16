using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_观察者设计模式__猫捉老鼠
{
    /// <summary>
    /// 猫类
    /// </summary>
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        /// <summary>
        /// 猫进屋（猫的状态发生改变），（被观察者的状态发生改变）
        /// </summary>
        //public void CatComing(Mouse mouse1, Mouse mouse2, Mouse mouse3)
        public void CatComing()
        {
            Console.WriteLine(color+"的猫"+name+"过来了，喵喵喵...");
            //mouse1.RunAway();
            //mouse2.RunAway();
            //mouse3.RunAway();
            if(catCome!=null)
            catCome();
        }

        public event Action catCome;//声明一个事件 发布一个消息
    }
}
