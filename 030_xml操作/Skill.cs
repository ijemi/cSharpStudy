using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_xml操作
{
    /// <summary>
    /// 技能类
    /// </summary>
    class Skill
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lang { get; set; }
        public int damage { get; set; }
        public override string ToString()
        {
            return string.Format("id:{0},name:{1},lang:{3},damage:{4}",id,name,lang,damage);
        }
    }
}
