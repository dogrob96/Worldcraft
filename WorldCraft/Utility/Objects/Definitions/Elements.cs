using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace Utility.Objects.Definitions
{
    class Elements
    {
        [XmlElement("Element")]
        public List<Element> ElementsList = new List<Element>();
    }
    class Element
    {
        [XmlElement("AtomicNumber")]
        public int AtomicNumber { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Symbol")]
        public string Symbol { get; set; }
        [XmlElement("Group")]
        public int Group { get; set; }
        [XmlElement("Period")]
        public int Period { get; set; }
        [XmlElement("Block")]
        public char Block { get; set; }
        [XmlElement("MeltingPoint")]
        public float MeltingPoint { get; set; }
        [XmlElement("BoilingPoint")]
        public float BoilingPoint { get; set; }
        [XmlElement("Isotopes")]
        public List<Isotope> Isotopes = new List<Isotope>();
        public int NumberOfElectrons { get; set; }
        public int CoreCharge { get; set; }
        public int ElectorNegativity { get; set; }

    }
    class Isotope
    {
        [XmlAttribute("Mass")]
        public int Mass { get; set; }
        [XmlAttribute("NaturalAbundance")]
        public float NaturalAbundance { get; set; }
    }
}
