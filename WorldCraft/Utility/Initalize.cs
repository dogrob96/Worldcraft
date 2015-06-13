using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.IO;
using Utility.Objects.Definitions;
namespace Utility
{
    class Initalize
    {
        public Elements ElementList;
        public void Initalizefunction()
        {
           ElementList = XmlDeserialization.DeserializeElements("");
            foreach(Element CurrentElement in ElementList.ElementsList)
            {
                CurrentElement.NumberOfElectrons = CurrentElement.AtomicNumber;
                CurrentElement.CoreCharge = CalculateCoreChare();
            }
        }
        public int CalculateCoreChare()
        {
            return 0;
        }
    }
}
