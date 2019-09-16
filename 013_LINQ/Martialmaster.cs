using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LINQ
{
    class Martialmaster
    {
        public int id { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }
        public  string MenPai { get; set; }

        public  string KongFU { get; set; }
        public  int Level { get; set; }
        public override string ToString()
        {
            return $"{nameof(id)}: {id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(MenPai)}: {MenPai}, {nameof(KongFU)}: {KongFU}, {nameof(Level)}: {Level}";
        }

    }
}
