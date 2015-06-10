using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Objects
{
    class Elements
    {
        public List<Element> Elements = new List<Element>();
    }
    class Element
    {
        public int AtomicNumber { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Group { get; set; }
        public int Period { get; set; }
        public char Block { get; set; }
        public float MeltingPoint { get; set; }
        public float BoilingPoint { get; set; }
        public List<Isotope> Isotopes = new List<Isotope>();
    }
    class Isotope
    {
        public int Mass { get; set; }
        public float NaturalAbundance { get; set; }
    }
}
