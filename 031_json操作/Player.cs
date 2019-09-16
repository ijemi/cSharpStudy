using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_json操作
{
    class Player
    {
        public string Name { get; set; }//字段或者属性名要和json里面的对应
        public int Level { get; set; }
        public int Age { get; set; }
        public List<Skill> SkillList { get; set; }
        public override string ToString()
        {
            return string.Format("Name:{0},Level:{1},Age:{2},SkillList:{3}", Name,Level,Age,SkillList);
        }
    }
}
