using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Objects
{
    class Ores
    {
        public List<Ore> Ores = new List<Ore>();
    }
    class Ore
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Makeup> Makeup = new List<Makeup>();
    }
    class Makeup
    {
        public int Amount { get; set; }
        public string Name { get; set; }
    }
}
