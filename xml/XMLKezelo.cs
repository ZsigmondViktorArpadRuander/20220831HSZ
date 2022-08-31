using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml
{
    internal static class XMLKezelo
    {
        #region Adattagok
        static XDocument xml;
        #endregion

        #region Alprogramok
        public static void EmberToXml(List<Ember> emberek, string fNev)
        {
            //XML file root node-janak elkeszitese
            xml = new XDocument(new XElement("emberek"));

            foreach (Ember e in emberek)
            {
                xml.Root.Add(new XElement("ember", /*new XAttribute("munka", 1),*/
                    new XElement("nev", e.Nev),
                    new XElement("email", e.Email),
                    new XElement("kor", e.Kor),
                    new XElement("nem", (e.Nem) ? "f" : "n")
                    ));
            }

            if (!fNev.EndsWith(".xml"))
            {
                fNev += ".xml";
            }

            xml.Save(fNev);
        }

        public static List<Ember> XMLToEmber(string path)
        {
            if (File.Exists(path))
            {
                xml = XDocument.Load(path);
                List<Ember> emberek = new List<Ember>();

                List<XElement> emberTagek = (from e in xml.Root.Elements("ember")
                                             select e).ToList();

                foreach (XElement node in emberTagek)
                {
                    emberek.Add(new Ember(
                        node.Element("nev").Value,
                        node.Element("email").Value,
                        Convert.ToUInt32(node.Element("kor").Value),
                        (node.Element("nem").Value == "f") ? true : false
                        ));
                }

                return emberek;
            }
            else
            {
                return new List<Ember>();
            }
        }
        #endregion
    }
}