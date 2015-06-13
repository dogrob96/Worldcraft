using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Utility.Objects.Definitions;
namespace Utility.IO
{
    class XmlDeserialization
    {
        public static Elements DeserializeElements(string filename)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Elements));
            try
            {
                TextReader reader = new StreamReader(@filename);
                object obj = deserializer.Deserialize(reader);
                Elements ElementList = (Elements)obj;
                reader.Close();
                return ElementList;
            }
            catch (Exception ex)
            {
                System.Console.Out.Write("deserialize Elements failed because of " + ex.ToString());
                return null;
            }
        }
    }
}
