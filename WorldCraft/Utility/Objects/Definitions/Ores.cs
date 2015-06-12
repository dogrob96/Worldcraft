using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace Utility.Objects.Definitions;
{
    class Ores
    {
        [XmlElement("Ore")]
        public List<Ore> OreList = new List<Ore>();
    }
    class Ore
    {
        [XmlElement("ID")]
        public int ID { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Makeup")]
        public List<Makeup> Makeup = new List<Makeup>();
    }
    class Makeup
    {
        [XmlAttribute("Amount")]
        public int Amount { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
    }
}
