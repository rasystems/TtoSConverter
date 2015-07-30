using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tractor_To_Serato_Converter.App.Classes
{
    class XMLFunctions
    {
        private List<String> TraktorListElements = new List<String>();

        public bool LoadXmlFile(String _FilePath)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load(_FilePath);

            XmlReader rdr = XmlReader.Create(_FilePath);
            while (rdr.Read())
            {
                if (rdr.NodeType == XmlNodeType.Element)
                {
                    TraktorListElements.Add(rdr.ReadInnerXml());
                }
            }

            /*
            foreach (System.Xml.XmlNode node in doc.SelectNodes("//PLAYLIST"))
            {
                
            }*/

            return true;
        }

        public List<String> GetTraktorListElement()
        {
            return this.TraktorListElements;
        }
    }
}
